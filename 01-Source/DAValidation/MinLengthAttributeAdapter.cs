using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class MinLengthAttributeAdapter : ValidationAttributeAdapter<MinLengthAttribute>
	{
		public MinLengthAttributeAdapter(MinLengthAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new MinLengthClientValidationRule(ErrorMessage, Attribute.Length) };
		}
	}
}