using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DAValidation.Sample.Entities;

namespace DAValidation.Sample.Pages
{
	public partial class GridViewInlineEdit : System.Web.UI.Page
	{
		protected override void OnInit(EventArgs e)
		{
			base.OnInit(e);

			Master.CodeViewer1.CommaDelimitedCodeFiles =
				"~/Pages/GridViewInlineEdit.aspx," +
				"~/Entities/Product.cs";
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			gvCustomers.DataSource = GetProducts();
			gvCustomers.DataBind();
		}

		public IEnumerable<Product> GetProducts()
		{
			yield return new Product { Id = 1, Name = "Cucumber", Amount = 10, Price = 4.2 };
			yield return new Product { Id = 2, Name = "Carrot", Amount = 5, Price = 21.67 };
			yield return new Product { Id = 3, Name = "Potato", Amount = 5, Price = 45.38 };
			yield return new Product { Id = 4, Name = "Tomato", Amount = 2, Price = 14.99 };
		}

		protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
		{
			if (Page.IsValid)
			{
				lblUpdateState.Text = "Validation passed";
				gvCustomers.EditIndex = -1;
				gvCustomers.DataBind();
			}
		}

		protected void OnRowEditing(object sender, GridViewEditEventArgs e)
		{
			gvCustomers.EditIndex = e.NewEditIndex;
			gvCustomers.DataBind();
		}

		protected void OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
		{
			gvCustomers.EditIndex = -1;
			gvCustomers.DataBind();
		}
	}
}