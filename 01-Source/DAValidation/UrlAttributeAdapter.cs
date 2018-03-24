using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class UrlAttributeAdapter : ValidationAttributeAdapter<UrlAttribute>
	{
		public UrlAttributeAdapter(UrlAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new UrlClientValidationRule(ErrorMessage) };
		}
	}
}