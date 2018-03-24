using System;
using System.Web.UI;

namespace DAValidation.Sample.Pages
{
	public partial class RangeAttributeExample : Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles = 
				"~/Pages/RangeAttributeExample.aspx," +
				"~/UserControls/RangesEdit.ascx," +
				"~/Entities/RangesModel.cs";
		}
	}
}