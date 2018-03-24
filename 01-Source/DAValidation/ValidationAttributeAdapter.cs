using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DAValidation
{
	internal class ValidationAttributeAdapter<T> : ValidationAttributeAdapter
		where T : ValidationAttribute
	{
		protected new T Attribute
		{
			get { return (T) base.Attribute; }
			set { base.Attribute = value; }
		}

		public ValidationAttributeAdapter(T attribute, string displayName)
			: base(attribute, displayName)
		{ }
	}

	internal class ValidationAttributeAdapter
	{
		protected ValidationAttribute Attribute { get; set; }
		protected string DisplayName { get; set; }
		protected string ErrorMessage { get; set; }

		public ValidationAttributeAdapter(ValidationAttribute attribute, string displayName)
		{
			Attribute = attribute;
			DisplayName = displayName;
			ErrorMessage = Attribute.FormatErrorMessage(DisplayName);
		}

		public virtual IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return Enumerable.Empty<ClientValidationRule>();
		}
	}
}