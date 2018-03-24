namespace DAValidation
{
	public class EmailAddressClientValidationRule : ClientValidationRule
	{
		public EmailAddressClientValidationRule(string errorMessage)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.EmailAddressValidatorEvaluateIsValid";
		}
	}
}