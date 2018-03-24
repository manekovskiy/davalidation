using System;
using System.Web.UI;

namespace DAValidation.Sample.Pages
{
	public partial class ValidationGroups : Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles =
				"~/Pages/ValidationGroups.aspx," +
				"~/UserControls/ContactInformationEdit.ascx," +
				"~/UserControls/AccountInformationEdit.ascx," +
				"~/Entities/ContactInformation.cs," +
				"~/Entities/AccountInformation.cs," +
				"~/CustomValidationAttributes/ValidatePasswordLengthAttribute.cs";
		}
	}
}