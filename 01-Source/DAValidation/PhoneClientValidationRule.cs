namespace DAValidation
{
	public class PhoneClientValidationRule : ClientValidationRule
	{
		public PhoneClientValidationRule(string errorMessage)
		{
			ErrorMessage = errorMessage;
			
			EvaluationFunction = "DAValidation.PhoneValidatorEvaluateIsValid";
		}
	}
}