using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class PhoneAttributeAdapter : ValidationAttributeAdapter<PhoneAttribute>
	{
		public PhoneAttributeAdapter(PhoneAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new PhoneClientValidationRule(ErrorMessage) };
		} 
	}
}