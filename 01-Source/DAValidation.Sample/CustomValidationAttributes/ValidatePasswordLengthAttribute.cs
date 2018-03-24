using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Security;

namespace DAValidation.Sample.CustomValidationAttributes
{
	// This validator taken from ASP.NET MVC 3 Website Template
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public class ValidatePasswordLengthAttribute : ValidationAttribute, IClientValidatable
	{
		private const string DefaultErrorMessage = "'{0}' must be at least {1} characters long.";
		private readonly int minCharacters = Membership.Provider.MinRequiredPasswordLength;

		private readonly string displayName;

		public ValidatePasswordLengthAttribute(string displayName)
			: base(DefaultErrorMessage)
		{
			this.displayName = displayName;
		}

		public override string FormatErrorMessage(string name)
		{
			return string.IsNullOrEmpty(ErrorMessage) 
				? string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, minCharacters) 
				: base.FormatErrorMessage(name);
		}

		public override bool IsValid(object value)
		{
			string valueAsString = value as string;
			return (valueAsString != null && valueAsString.Length >= minCharacters);
		}

		public IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			yield return new StringLengthClientValidationRule(FormatErrorMessage(displayName), minCharacters, int.MaxValue);
		}
	}
}