namespace DAValidation
{
	public class FileExtensionsClientValidationRule : ClientValidationRule
	{
		public FileExtensionsClientValidationRule(string errorMessage, string extensions)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.FileExtensionsValidatorEvaluateIsValid";

			Parameters["extensions"] = extensions;
		}
	}
}