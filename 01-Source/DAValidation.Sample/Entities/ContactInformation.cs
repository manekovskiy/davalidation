using System.ComponentModel.DataAnnotations;

namespace DAValidation.Sample.Entities
{
	public class ContactInformation
	{
		[Display(Name = "First Name")]
		[Required(ErrorMessage = "Please enter your first name")]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Display(Name = "Middle Initial")]
		[StringLength(10)]
		public string MiddleInitial { get; set; }

		[Display(Name = "Last Name")]
		[Required(ErrorMessage = "Please enter your last name")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Display(Name = "Company Name")]
		[StringLength(50)]
		public string CompanyName { get; set; }

		[Display(Name = "Email Address")]
		[Required(ErrorMessage = "Your email address is required")]
		[StringLength(200)]
		[RegularExpression(@"^(\s)*[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?(\s)*", ErrorMessage = "Please type a valid email address")]
		public string EmailAddress { get; set; }

		[Display(Name = "Contact Phone")]
		[Required(ErrorMessage = "Your phone number is required")]
		[RegularExpression(@"^(1?(-?\d{3})-?)?(\d{3})(-?\d{4})$", ErrorMessage = "Please type a valid phone number (7, 10 or 11 digits with or without hyphens)")]
		public string ContactPhone { get; set; }

		[Display(Name = "Street Address")]
		[Required(ErrorMessage = "Your street address is required")]
		[StringLength(50)]
		public string StreetAddress { get; set; }

		[Display(Name = "Apartament")]
		[StringLength(5)]
		public string Apartament { get; set; }

		[Display(Name = "City")]
		[Required(ErrorMessage = "Your city is required")]
		[StringLength(50)]
		public string City { get; set; }

		[Display(Name = "State")]
		[Required(ErrorMessage = "Your state is required")]
		[StringLength(50)]
		public string State { get; set; }
		
		[Display(Name = "Zip")]
		[Required(ErrorMessage = "Your zip code is required")]
		[RegularExpression(@"\d{5}(-\d{4})?", ErrorMessage = "Please type a valid zip code")]
		public string Zip { get; set; }

		[Display(Name = "Comments")]
		[StringLength(1000, MinimumLength = 0)]
		public string Comments { get; set; }
	}
}