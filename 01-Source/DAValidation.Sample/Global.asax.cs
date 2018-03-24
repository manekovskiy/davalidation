using System;
using System.Web;
using System.Web.UI;

namespace DAValidation.Sample
{
	public class Global : HttpApplication
	{
		protected void Application_Start(object sender, EventArgs e)
		{
			ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
			{
				Path = "~/scripts/jquery-1.6.2.min.js",
				DebugPath = "~/scripts/jquery-1.6.2.min.js"
			});

			ScriptManager.ScriptResourceMapping.AddDefinition("jquery-ui", new ScriptResourceDefinition
			{
				Path = "~/scripts/jquery-ui-1.8.16.custom.min.js",
				DebugPath = "~/scripts/jquery-ui-1.8.16.custom.min.js"
			});

			ScriptManager.ScriptResourceMapping.AddDefinition("syntaxHighlighter", new ScriptResourceDefinition
			{
				Path = "~/scripts/syntaxHighlighter.js",
				DebugPath = "~/scripts/syntaxHighlighter.js"
			});

#if NET45
			// comment this line to use standard validation mode in .NET 4.5
			ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.WebForms;
#endif
		}
	}
}