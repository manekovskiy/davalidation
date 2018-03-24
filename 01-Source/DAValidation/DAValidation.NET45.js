if (typeof DAValidation === "undefined")
	DAValidation = (function () {
		return {
			RegularExpressions: {
				Email: new RegExp("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$", "i"),
				FileExtensions: function (commaDelimitedExtensions) {
					var extensions = commaDelimitedExtensions.split(",");
					for (var i = 0; i < extensions.length; i++) {
						extensions[i] = ValidatorTrim(extensions[i]);
					}
					
					var pattern = "^.*\\.(" + extensions.join("|") + ")$";
					return new RegExp(pattern, "i");
				},
				Phone: new RegExp("^(\\d+\\s?(x|\\.txe?)\\s?)?((\\)(\\d+[\\s\\-\\.]?)?\\d+\\(|\\d+)[\\s\\-\\.]?)*(\\)([\\s\\-\\.]?\\d+)?\\d+\\+?\\((?!\\+.*)|\\d+)(\\s?\\+)?$", "i"),
				Url: new RegExp("^(https?|ftp):\\/\\/(((([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-f]{2})|[!\\$&'\\(\\)\\*\\+,;=]|:)*@)?(((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5]))|((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?)(:\\d*)?)(\\/((([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-f]{2})|[!\\$&'\\(\\)\\*\\+,;=]|:|@)+(\\/(([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-f]{2})|[!\\$&'\\(\\)\\*\\+,;=]|:|@)*)*)?)?(\\?((([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-f]{2})|[!\\$&'\\(\\)\\*\\+,;=]|:|@)|[\\uE000-\\uF8FF]|\\/|\\?)*)?(\\#((([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-f]{2})|[!\\$&'\\(\\)\\*\\+,;=]|:|@)|\\/|\\?)*)?$", "i")
			},

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
			},

			MaxLengthValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				if (value.length <= parseInt(val.maxlength) || parseInt(val.maxlength) === -1)
					return true;

				return false;
			},

			MinLengthValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				if (value.length >= parseInt(val.minlength))
					return true;

				return false;
			},

			CreditCardValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate)).replace(/-/g, "").replace(/\s+/g, "");

				if (!value.substring || value == "")
					return false;

				var summ = 0;
				var i;
				for (i = 2 - value.length % 2; i <= value.length; i += 2) {
					summ += parseInt(value.charAt(i - 1));
				}

				for (i = (value.length % 2) + 1; i < value.length; i += 2) {
					var digit = parseInt(value.charAt(i - 1)) * 2;

					summ += digit < 10 ? digit : digit - 9;
				}
				return (summ % 10) == 0;
			},

			EmailAddressValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				return this.RegularExpressions.Email.test(value);
			},

			FileExtensionsValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				return this.RegularExpressions.FileExtensions(val.extensions).test(value);
			},

			UrlValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				return this.RegularExpressions.Url.test(value);
			},

			PhoneValidatorEvaluateIsValid: function (val) {
				var value = ValidatorTrim(ValidatorGetValue(val.controltovalidate));
				var reversedValue = value.split("").reverse().join("");
				return this.RegularExpressions.Phone.test(reversedValue);
			}
		};
	})();