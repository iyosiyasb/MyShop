using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyShop.Models
{
	[Table("Employees")]
	public class Employee
	{
		[Key]
		public string EmployeeId { get; set; }
		[StringLength(100)]
		public string FirstName { get; set; }
		[StringLength(100)]

		public string LastName { get; set; }
		[StringLength(100)]

		public string Address { get; set; }
		[StringLength(100)]
		public string Email { get; set; }
		[StringLength(50)]
		public string City { get; set; }
		[StringLength(50)]

		public string Country { get; set; }

	}
}