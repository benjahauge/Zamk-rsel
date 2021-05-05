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
		[StringLength(50)]
		public string Name { get; set; }

        
		public int Age { get; set; }

        [StringLength(50)]
		public string Address { get; set; }

        [StringLength(50)]
		public string Role { get; set; }

		
		public virtual ICollection<Booking> Bookings { get; set; }
	}
}
