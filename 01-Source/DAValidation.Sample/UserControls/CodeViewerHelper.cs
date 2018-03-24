using System.Collections.Generic;
using System.IO;
using System.Web;

namespace DAValidation.Sample.UserControls
{
	public class CodeViewerHelper
	{
		private static readonly List<string> KnownExtensions = new List<string> { ".cs", ".aspx", ".ascx", ".master" };
		private static readonly Dictionary<string, string> BrushesByExtensions = new Dictionary<string, string>
		{ 
			{".cs", "csharp"},
			{".aspx", "xml"},
			{".master", "xml"},
			{".ascx", "xml"}
		};

		public static string GetFileNameWithoutExtension(string virtualFileName)
		{
			EnsureVirtualPathIsValidAndAccessible(virtualFileName);

			return Path.GetFileNameWithoutExtension(HttpContext.Current.Server.MapPath(virtualFileName));
		}

		public static string GetFileName(string virtualFileName)
		{
			EnsureVirtualPathIsValidAndAccessible(virtualFileName);

			return Path.GetFileName(HttpContext.Current.Server.MapPath(virtualFileName));
		}

		public static string RenderFileContents(string virtualFileName)
		{
			EnsureVirtualPathIsValidAndAccessible(virtualFileName);

			return HttpUtility.HtmlEncode(File.ReadAllText(HttpContext.Current.Server.MapPath(virtualFileName)));
		}

		public static string GetBrushNameForFile(string virtualFileName)
		{
			EnsureVirtualPathIsValidAndAccessible(virtualFileName);

			var extension = Path.GetExtension(HttpContext.Current.Server.MapPath(virtualFileName));
			return BrushesByExtensions[extension];
		}

		private static void EnsureVirtualPathIsValidAndAccessible(string virtualFileName)
		{
			string absolutePath = HttpContext.Current.Server.MapPath(virtualFileName);
			string currentAbsolutePath = HttpContext.Current.Request.PhysicalApplicationPath;

			if (string.IsNullOrEmpty(absolutePath) ||
				string.IsNullOrEmpty(currentAbsolutePath) ||
				!KnownExtensions.Contains(Path.GetExtension(absolutePath).ToLowerInvariant()) ||
				!absolutePath.ToLower().StartsWith(currentAbsolutePath.ToLower()))
				throw new HttpException(403, "Unauthorized");
		}
	}
}