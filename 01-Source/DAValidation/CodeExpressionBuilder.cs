using System.Web.Compilation;
using System.CodeDom;

namespace DAValidation
{
	/// <summary>
	/// CodeExpressionBuilder by Dave Ree
	/// http://weblogs.asp.net/infinitiesloop/archive/2006/08/09/The-CodeExpressionBuilder.aspx
	/// </summary>
	public class CodeExpressionBuilder : ExpressionBuilder
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "I dont think this is good idea, I want exception to be thrown if entry parameter is invalid, so it is ok for me if runtime will do it.")]
		public override CodeExpression GetCodeExpression(System.Web.UI.BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context)
		{
			return new CodeSnippetExpression(entry.Expression.Trim());
		}
	}
}
