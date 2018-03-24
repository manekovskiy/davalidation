using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation
{
	internal class FileExtensionsAttributeAdapter : ValidationAttributeAdapter<FileExtensionsAttribute>
	{
		public FileExtensionsAttributeAdapter(FileExtensionsAttribute attribute, string displayName)
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new FileExtensionsClientValidationRule(ErrorMessage, Attribute.Extensions) };
		}
	}
}