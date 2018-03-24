using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class MaxLengthAttributeAdapter : ValidationAttributeAdapter<MaxLengthAttribute>
	{
		public MaxLengthAttributeAdapter(MaxLengthAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new MaxLengthClientValidationRule(ErrorMessage, Attribute.Length) };
		}
	}
}