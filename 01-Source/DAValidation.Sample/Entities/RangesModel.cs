using System;
using System.ComponentModel.DataAnnotations;

namespace DAValidation.Sample.Entities
{
	public class RangesModel
	{
		[Range(0, int.MaxValue)]
		public int IntRange { get; set; }

		[Range(0.0, 1.0, ErrorMessage = "Value for {0} must be between {1} and {2}")]
		public double DoubleRange { get; set; }

		[Range(typeof(DateTime), "1/1/2012", "3/4/2013", ErrorMessage = "Value for {0} must be between {1} and {2}")]
		public DateTime DateRange { get; set; }

		[Range(1, 5, ErrorMessage = "Value for {0} must be between {1} and {2}")]
		public int? NullableIntRange { get; set; }
	}
}