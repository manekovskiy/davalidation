namespace DAValidation
{
	public class UrlClientValidationRule : ClientValidationRule
	{
		public UrlClientValidationRule(string errorMessage)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.UrlValidatorEvaluateIsValid";
		}
	}
}