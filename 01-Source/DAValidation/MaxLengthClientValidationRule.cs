namespace DAValidation
{
	public class MaxLengthClientValidationRule : ClientValidationRule
	{
		public MaxLengthClientValidationRule(string errorMessage, int length)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.MaxLengthValidatorEvaluateIsValid";

			Parameters["maxlength"] = length;
		}
	}
}