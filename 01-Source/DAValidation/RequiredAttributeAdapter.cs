﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DAValidation
{
	[SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "This class is instantiated and used in ValidationAttributeAdapterFactory class")]
	internal class RequiredAttributeAdapter : ValidationAttributeAdapter<RequiredAttribute>
	{
		public RequiredAttributeAdapter(RequiredAttribute attribute, string displayName) 
			: base(attribute, displayName)
		{ }

		public override IEnumerable<ClientValidationRule> GetClientValidationRules()
		{
			return new[] { new RequiredClientValidationRule(ErrorMessage) };
		}
	}
}