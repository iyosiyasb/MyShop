using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyShop.Models
{
	[Table("Products")]
	public class Product4
	{
		[Key]
		public string ProductId { get; set; }
		[StringLength(100)]
		public string ProductName { get; set; }
		[StringLength(100)]
		public string ProductPrice { get; set; }
	}
}