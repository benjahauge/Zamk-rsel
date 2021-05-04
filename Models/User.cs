using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zamkørsel.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required]
		[StringLength(20)]
		public string Username { get; set; }

		[Required]
		[StringLength(30, MinimumLength = 8)]
		public string Password { get; set; }

		[Required]
		[StringLength(40)]
		public string Email { get; set; }

		[StringLength(11)]
		public string PhoneNumber { get; set; }
	}
}
