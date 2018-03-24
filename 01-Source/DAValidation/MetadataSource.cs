using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.DynamicData;
using System.Web.UI;

namespace DAValidation
{
	public class MetadataSource : Control
	{
		public Type ObjectType { get; set; }

		private MetaTable metaTable;
		private MetaTable MetaTable
		{
			get { return metaTable ?? (metaTable = MetaTable.CreateTable(ObjectType)); }
		}

		public IEnumerable<ValidationAttribute> GetValidationAttributes(string property)
		{
			return MetaTable.GetColumn(property).Attributes.OfType<ValidationAttribute>();
		}

		public string GetDisplayName(string objectProperty)
		{
			var displayAttribute = MetaTable.GetColumn(objectProperty).Attributes
				.OfType<DisplayAttribute>()
				.FirstOrDefault<DisplayAttribute>();

			return displayAttribute == null ? objectProperty : displayAttribute.GetName();
		}
	}
}