using System;
using System.Web.UI;

namespace DAValidation.Sample.Pages
{
	public partial class UpdatePanelExample : Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles = 
				"~/Pages/UpdatePanelExample.aspx," +
				"~/UserControls/ContactInformationEdit.ascx," +
				"~/Entities/ContactInformation.cs";
		}
	}
}