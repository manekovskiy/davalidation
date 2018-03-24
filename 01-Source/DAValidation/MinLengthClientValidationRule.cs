namespace DAValidation
{
	public class MinLengthClientValidationRule : ClientValidationRule
	{
		public MinLengthClientValidationRule(string errorMessage, int length)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.MinLengthValidatorEvaluateIsValid";

			Parameters["minlength"] = length;
		}
	}
}