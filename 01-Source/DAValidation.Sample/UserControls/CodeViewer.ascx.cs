using System;
using System.Web.UI;

namespace DAValidation.Sample.UserControls
{
	public partial class CodeViewer : UserControl
	{
		public const string CommaDelimitedCodeFilesViewStateKey = "CodeViewer_CommaDelimitedCodeFiles";
		public string CommaDelimitedCodeFiles
		{ 
			get { return Convert.ToString(ViewState[CommaDelimitedCodeFilesViewStateKey]); }
			set { ViewState[CommaDelimitedCodeFilesViewStateKey] = value; }
		}

		private string[] codeFilesVirtualPaths = new string[] { };
		private string[] CodeFilesVirtualPaths
		{
			get
			{
				if(codeFilesVirtualPaths.Length == 0 && !string.IsNullOrEmpty(CommaDelimitedCodeFiles))
				{
					codeFilesVirtualPaths = CommaDelimitedCodeFiles.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
				}
				return codeFilesVirtualPaths;
			}
		}

		protected override void  OnLoad(EventArgs e)
		{
			rpCodeFilesContent.DataSource = CodeFilesVirtualPaths;
			rpCodeFilesTabs.DataSource = CodeFilesVirtualPaths;

			rpCodeFilesTabs.DataBind();
			rpCodeFilesContent.DataBind();
			
			base.OnLoad(e);
		}
	}
}