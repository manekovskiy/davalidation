namespace DAValidation
{
	public class CreditCardClientValidationRule : ClientValidationRule
	{
		public CreditCardClientValidationRule(string errorMessage)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.CreditCardValidatorEvaluateIsValid";
		}
	}
}