using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAValidation.Sample.UserControls;

namespace DAValidation.Sample
{
	public partial class Site : MasterPage
	{
		public CodeViewer CodeViewer1 { get; set; }

		public Menu mainMenu { get; set; }
#if NET45
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			var newAttributesMenuItem = new MenuItem("New Attributes in .NET 4.5", "newAttributes", "", "~/Pages/NewAttibutesInNET45.aspx");
			if (!mainMenu.Items.Cast<MenuItem>().Any(item => item.Value == "newAttributes"))
				mainMenu.Items.Add(newAttributesMenuItem);

			var gridStronglyTypedBindings = new MenuItem("Strongly typed grid example (No MetadataSource)", "gridStronglyTypedBindings", "", "~/Pages/GridStronglyTypedBindings.aspx");
			if (!mainMenu.Items.Cast<MenuItem>().Any(item => item.Value == "gridStronglyTypedBindings"))
				mainMenu.Items.Add(gridStronglyTypedBindings);
		}
#endif
	}
}