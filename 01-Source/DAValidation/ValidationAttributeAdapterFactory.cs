using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace DAValidation
{
	internal static class ValidationAttributeAdapterFactory
	{
		private static readonly Dictionary<Type, Func<ValidationAttribute, string, ValidationAttributeAdapter>> PredefinedCreators
			= new Dictionary<Type, Func<ValidationAttribute, string, ValidationAttributeAdapter>>
			{
				{
					typeof(RangeAttribute),
					(attribute, displayName) => new RangeAttributeAdapter((RangeAttribute)attribute, displayName)
				}, {
					typeof(RegularExpressionAttribute),
					(attribute, displayName) => new RegularExpressionAttributeAdapter((RegularExpressionAttribute)attribute, displayName)
				}, {
					typeof(RequiredAttribute),
					(attribute, displayName) => new RequiredAttributeAdapter((RequiredAttribute)attribute, displayName)
				}, {
					typeof (StringLengthAttribute),
					(attribute, displayName) => new StringLengthAttributeAdapter((StringLengthAttribute)attribute, displayName)
				},
#if NET45
				{
					typeof(CreditCardAttribute),
					(attribute, displayName) => new CreditCardAttributeAdapter((CreditCardAttribute)attribute, displayName)
				}, {
					typeof(EmailAddressAttribute),
					(attribute, displayName) => new EmailAddressAttributeAdapter((EmailAddressAttribute)attribute, displayName)
				}, {
					typeof(FileExtensionsAttribute),
					(attribute, displayName) => new FileExtensionsAttributeAdapter((FileExtensionsAttribute)attribute, displayName)
				}, {
					typeof(MaxLengthAttribute),
					(attribute, displayName) => new MaxLengthAttributeAdapter((MaxLengthAttribute)attribute, displayName)
				}, {
					typeof(MinLengthAttribute),
					(attribute, displayName) => new MinLengthAttributeAdapter((MinLengthAttribute)attribute, displayName)
				}, {
					typeof(PhoneAttribute),
					(attribute, displayName) => new PhoneAttributeAdapter((PhoneAttribute)attribute, displayName)
				}, {
					typeof(UrlAttribute),
					(attribute, displayName) => new UrlAttributeAdapter((UrlAttribute)attribute, displayName)
				}
#endif
			};

		public static ValidationAttributeAdapter Create(ValidationAttribute attribute, string displayName)
		{
			Debug.Assert(attribute != null, "attribute parameter must not be null");
			Debug.Assert(!string.IsNullOrWhiteSpace(displayName), "displayName parameter must not be null, empty or whitespace string");

			// Added suport for ValidationAttribute subclassing. See http://davalidation.codeplex.com/workitem/695
			var baseType = attribute.GetType();
			Func<ValidationAttribute, string, ValidationAttributeAdapter> predefinedCreator;
			do
			{
				if (!PredefinedCreators.TryGetValue(baseType, out predefinedCreator))
					baseType = baseType.BaseType;
			}
			while (predefinedCreator == null && baseType != null && baseType != typeof(Attribute));

			return predefinedCreator != null 
				? predefinedCreator(attribute, displayName) 
				: new ValidationAttributeAdapter(attribute, displayName);
		}
	}
}