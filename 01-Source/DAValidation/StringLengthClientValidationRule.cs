using System.Globalization;

namespace DAValidation
{
	public class StringLengthClientValidationRule : ClientValidationRule
	{
		public StringLengthClientValidationRule(string errorMessage, int minimumLength, int maximumLength)
		{
			ErrorMessage = errorMessage;

			EvaluationFunction = "DAValidation.StringLengthValidatorEvaluateIsValid";

			string maxLengthStr = maximumLength == int.MaxValue ? "0" : maximumLength.ToString(CultureInfo.InvariantCulture);

			Parameters["minlength"] = minimumLength;
			Parameters["maxlength"] = maxLengthStr;
		}
	}
}