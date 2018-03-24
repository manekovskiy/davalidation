using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAValidation.Sample.Entities
{
	public class Product
	{
		[Display(Name = "Code")]
		[Range(0, int.MaxValue)]
		public int Id { get; set; }

		[Display(Name = "Product Name")]
		[Required]
		[StringLength(64)]
		public string Name { get; set; }

		[Display(Name = "Price")]
		[Range(1.0, 100.0)]
		public double Price { get; set; }

		[Display(Name = "Amount")]
		[Range(0, int.MaxValue)]
		public int Amount { get; set; }
	}
}