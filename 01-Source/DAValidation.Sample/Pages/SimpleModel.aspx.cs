using System;
using System.Web.UI;

namespace DAValidation.Sample.Pages
{
	public partial class SimpleModel : Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles = 
				"~/Pages/SimpleModel.aspx," +
				"~/UserControls/AccountInformationEdit.ascx," +
				"~/Entities/ContactInformation.cs";
		}
	}
}