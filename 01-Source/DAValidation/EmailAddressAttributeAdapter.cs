using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class EmailAddressAttributeAdapter : ValidationAttributeAdapter<EmailAddressAttribute>
	{
		public EmailAddressAttributeAdapter(EmailAddressAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new EmailAddressClientValidationRule(ErrorMessage) };
		}
	}
}