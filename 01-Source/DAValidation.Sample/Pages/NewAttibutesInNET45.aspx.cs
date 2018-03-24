using System;
using System.Web.UI;

namespace DAValidation.Sample.Pages
{
	public partial class NewAttibutesInNET45 : Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles =
				"~/Pages/NewAttibutesInNET45.aspx," +
				"~/UserControls/CustomerEdit.ascx," +
				"~/Entities/Customer.cs";
		}
	}
}