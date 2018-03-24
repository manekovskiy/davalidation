using System;
using System.Web.UI;

namespace DAValidation.Sample.Pages
{
	public partial class CustomAttribute : Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles = 
				"~/Pages/CustomAttribute.aspx," +
				"~/UserControls/AccountInformationEdit.ascx," +
				"~/Entities/AccountInformation.cs," +
				"~/CustomValidationAttributes/ValidatePasswordLengthAttribute.cs";
		}
	}
}