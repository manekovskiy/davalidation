using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class CreditCardAttributeAdapter : ValidationAttributeAdapter<CreditCardAttribute>
	{
		public CreditCardAttributeAdapter(CreditCardAttribute attribute, string displayName) 
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new CreditCardClientValidationRule(ErrorMessage) };
		}
	}
}