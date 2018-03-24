namespace DAValidation
{
	public class RequiredClientValidationRule : ClientValidationRule
	{
		public RequiredClientValidationRule(string errorMessage)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "RequiredFieldValidatorEvaluateIsValid";
			
			Parameters["initialvalue"] = string.Empty;
		}
	}
}