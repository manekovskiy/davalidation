using System;
using System.Collections;
using System.Web.UI;

namespace DAValidation.Sample.UserControls
{
	public partial class AccountInformationEdit : UserControl
	{
		public IEnumerable GetData()
		{
			yield return new { Foo = 1, Bar = "Bar 1" };
			yield return new { Foo = 2, Bar = "Bar 2" };
			yield return new { Foo = 3, Bar = "Bar 3" };
			yield return new { Foo = 4, Bar = "Bar 4" };
			yield return new { Foo = 5, Bar = "Bar 5" };
		}

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected override void LoadControlState(object savedState)
		{
			var v = savedState;
			base.LoadControlState(savedState);
		}

		protected override void LoadViewState(object savedState)
		{
			var v = savedState;
			base.LoadViewState(savedState);
		}
	}
}