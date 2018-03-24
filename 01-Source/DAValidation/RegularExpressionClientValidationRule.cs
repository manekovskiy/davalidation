using System.Web;

namespace DAValidation
{
	public class RegularExpressionClientValidationRule : ClientValidationRule
	{
		public RegularExpressionClientValidationRule(string errorMessage, string pattern)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "RegularExpressionValidatorEvaluateIsValid";

			Parameters["validationexpression"] = pattern;
		}
	}
}