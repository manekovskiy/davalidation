using System.Globalization;
using System.Web;
using System.Web.UI;

namespace DAValidation
{
	internal static class ControlExtensions
	{
		/// <summary>
		/// Assumes that startingControl is NOT the control you are searching for.    
		/// </summary>
		public static T FindChildControl<T>(this Control startingControl, string id)
			where T : Control
		{
			Control currentContainer = startingControl;
			Control found = null;

			if (startingControl == startingControl.Page)
			{
				return (T)startingControl.FindControl(id);
			}

			while (found == null && currentContainer != startingControl.Page)
			{
				currentContainer = currentContainer.NamingContainer;
				if (currentContainer == null)
				{
					throw new HttpException(string.Format(CultureInfo.InvariantCulture, "Naming container was not found for {0}", startingControl.GetType().Name));
				}
				found = currentContainer.FindControl(id);
			}

			return (T)found;
		}

#if !NET45 // Unobtrusive validation support. See http://davalidation.codeplex.com/workitem/702
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "writer", 
			Justification = "The parameter is preserved to reduce amount of conditional compilation blocks")]
		public static void RegisterExpandoAttribute(this Control control, HtmlTextWriter writer, string attributeName, string attributeValue, bool encode = false)
		{
			var scriptManager = ScriptManager.GetCurrent(control.Page);
			if (scriptManager != null && scriptManager.IsInAsyncPostBack)
				ScriptManager.RegisterExpandoAttribute(control, control.ClientID, attributeName, attributeValue, encode);
			else
				control.Page.ClientScript.RegisterExpandoAttribute(control.ClientID, attributeName, attributeValue, encode);
		}
#else
		public static void RegisterExpandoAttribute(this Control control, HtmlTextWriter writer, string attributeName, string attributeValue, bool encode = false)
		{
			if (writer != null && control.Page.UnobtrusiveValidationMode != UnobtrusiveValidationMode.None)
			{
				attributeName = "data-val-" + attributeName;
				writer.AddAttribute(attributeName, attributeValue, encode);
			}
			else
			{
				var scriptManager = ScriptManager.GetCurrent(control.Page);
				if (scriptManager != null && scriptManager.IsInAsyncPostBack)
					ScriptManager.RegisterExpandoAttribute(control, control.ClientID, attributeName, attributeValue, encode);
				else
					control.Page.ClientScript.RegisterExpandoAttribute(control.ClientID, attributeName, attributeValue, encode);
			}
		}
#endif
	}
}