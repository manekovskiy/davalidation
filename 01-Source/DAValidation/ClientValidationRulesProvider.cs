using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal static class ClientValidationRulesProvider
	{
		public static IEnumerable<ClientValidationRule> GetClientValidationRules(ValidationAttribute attribute, string displayName)
		{
			var validatableAttribute = (attribute as IClientValidatable);
			if (validatableAttribute != null)
				return validatableAttribute.GetClientValidationRules();

			var dataAnnotationsValidator = ValidationAttributeAdapterFactory.Create(attribute, displayName);
			return dataAnnotationsValidator.GetClientValidationRules();
		}
	}
}