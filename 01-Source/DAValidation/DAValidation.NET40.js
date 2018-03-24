if (typeof DAValidation === "undefined")
	DAValidation = (function () {
		return {
			DataAnnotationsValidatorIsValid: function (val) {
				var functionsToEvaluate = val.validatorfunctions.split(';;');
				var errorMessages = val.errormessages.split(';;');

				for (var funcIndex in functionsToEvaluate) {
					var result = eval(functionsToEvaluate[funcIndex] + "(val)");
					if (result === false) {
						val.errormessage = errorMessages[funcIndex];
						if (val.supresserrormessagetext === "false") {
							val.innerHTML = errorMessages[funcIndex];
						}
						return false;
					}
				}
				return true;
			},

			StringLengthValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				if (value.length >= parseInt(val.minlength) && (value.length <= parseInt(val.maxlength) || parseInt(val.maxlength) === 0))
					return true;

				return false;
			}
		};
	})();