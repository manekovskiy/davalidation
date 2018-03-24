using System.ComponentModel.DataAnnotations;

namespace DAValidation.Sample.Entities
{
	public class Customer
	{
		// I dont think "Wolfe+585, Senior" (see http://en.wikipedia.org/wiki/Longest_name) will be used in this sample, so length of 50 characters is enough
		[Display(Name = "Name")]
		[MinLength(2)]
		[MaxLength(50)]
		public string Name { get; set; }

		[Display(Name = "Email Address")]
		[EmailAddress]
		public string EmailAddress { get; set; }

		[Display(Name = "Photo")]
		[FileExtensions(Extensions = "jpg, jpeg, png, bmp")]
		public string PhotoFilePath { get; set; }

		[Display(Name = "Phone Number")]
		[Phone]
		public string Phone { get; set; }

		// Valid credit card number could be taken from http://www.fakenamegenerator.com/
		[Display(Name = "Credit Card Number")]
		[CreditCard]
		public string CreditCardNumber { get; set; }

		[Display(Name = "Website URL")]
		[Url]
		public string Website { get; set; }
	}
}