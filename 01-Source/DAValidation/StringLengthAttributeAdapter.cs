using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DAValidation
{
	[SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "This class is instantiated and used in ValidationAttributeAdapterFactory class")]
	internal class StringLengthAttributeAdapter : ValidationAttributeAdapter<StringLengthAttribute>
	{
		internal StringLengthAttributeAdapter(StringLengthAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new StringLengthClientValidationRule(ErrorMessage, Attribute.MinimumLength, Attribute.MaximumLength) };
		}
	}
}