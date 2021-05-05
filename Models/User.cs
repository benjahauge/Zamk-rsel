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
		public string Name { get; set; }

		[Required]
		[StringLength(20)]
		public int Age { get; set; }

		[Required]
        public Type Role { get; set; }

		[Required]
		public virtual ICollection<Booking> Bookings { get; set; }
	}
}
