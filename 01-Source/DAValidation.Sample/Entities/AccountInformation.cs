using System.ComponentModel.DataAnnotations;
using DAValidation.Sample.CustomValidationAttributes;

namespace DAValidation.Sample.Entities
{
	public class AccountInformation
	{
		[Display(Name = "Username")]
		[Required(ErrorMessageResourceName = "AccountInformation_Username_Required", ErrorMessageResourceType = typeof(Resources.AccountInformation))]
		[StringLength(10)]
		public string Username { get; set; }

		[Display(Name = "Password")]
		[Required(ErrorMessageResourceName = "AccountInformation_Password_Required", ErrorMessageResourceType = typeof(Resources.AccountInformation))]
		[ValidatePasswordLength("Password")]
		public string Password { get; set; }

		[Display(Name = "Password Confirmation")]
		[Required(ErrorMessageResourceName = "AccountInformation_PasswordConfirmation_Required", ErrorMessageResourceType = typeof(Resources.AccountInformation))]
		public string PasswordConfirmation { get; set; }

		[Display(Name = "Security Question")]
		[Required(ErrorMessageResourceName = "AccountInformation_SecurityQuestion_Required", ErrorMessageResourceType = typeof(Resources.AccountInformation))]
		[StringLength(100)]
		public string SecurityQuestion { get; set; }

		[Display(Name = "Security Answer")]
		[Required(ErrorMessageResourceName = "AccountInformation_SecurityAnswer_Required", ErrorMessageResourceType = typeof(Resources.AccountInformation))]
		[StringLength(100)]
		public string SecurityAnswer { get; set; }
	}
}