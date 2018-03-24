using System.Collections.Generic;

namespace DAValidation
{
	public class ClientValidationRule
	{
		public string EvaluationFunction { get; set; }
		public Dictionary<string, object> Parameters { get; private set; }

		public string ErrorMessage { get; set; }

		public ClientValidationRule()
		{
			Parameters = new Dictionary<string, object>();
			EvaluationFunction = string.Empty;
		}
	}
}