using System;
using System.Diagnostics;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAValidation
{
	public class RangeClientValidationRule : ClientValidationRule
	{
		public RangeClientValidationRule(string errorMessage, object minValue, object maxValue, Type operandType)
		{
			// Since standard aps.net validation library supports only Int32, Double, String and DateTime types
			// then we will not try to validate other types on client side
			ValidationDataType? validationDataType = GetValidationDataType(operandType);
			if(!validationDataType.HasValue)
				return;

			ErrorMessage = errorMessage;

			EvaluationFunction = "RangeValidatorEvaluateIsValid";

			Parameters["maximumvalue"] = maxValue;
			Parameters["minimumvalue"] = minValue;

			Parameters["type"] = PropertyConverter.EnumToString(typeof(ValidationDataType), validationDataType.Value);

			NumberFormatInfo numberFormat = NumberFormatInfo.CurrentInfo;
			if (validationDataType.Value == ValidationDataType.Double)
			{
				Parameters["decimalchar"] = numberFormat.NumberDecimalSeparator;
			}
			else if (validationDataType.Value == ValidationDataType.Date)
			{
				int currentYear = DateTime.Today.Year;
				int century = currentYear - (currentYear % 100);
				
				DateTimeFormatInfo dateFormat = DateTimeFormatInfo.CurrentInfo;
				Debug.Assert(dateFormat != null, "dateFormat != null");

				string shortPattern = dateFormat.ShortDatePattern;
				string dateElementOrder;
				string cutoffYear = dateFormat.Calendar.TwoDigitYearMax.ToString(NumberFormatInfo.InvariantInfo);
				if (shortPattern.IndexOf('y') < shortPattern.IndexOf('M'))
				{
					dateElementOrder = "ymd";
				}
				else if (shortPattern.IndexOf('M') < shortPattern.IndexOf('d'))
				{
					dateElementOrder = "mdy";
				}
				else
				{
					dateElementOrder = "dmy";
				}

				Parameters["dateorder"] = dateElementOrder;
				Parameters["cutoffyear"] = cutoffYear;
				Parameters["century"] = century.ToString(NumberFormatInfo.InvariantInfo);
			}
		}

		private static ValidationDataType? GetValidationDataType(Type operandType)
		{
			if (operandType == typeof(int))
				return ValidationDataType.Integer;
			if (operandType == typeof(double))
				return ValidationDataType.Double;
			if (operandType == typeof(DateTime))
				return ValidationDataType.Date;
			if (operandType == typeof(string))
				return ValidationDataType.String;

			return null;
		}
	}
}