using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zamkørsel.Models
{
	public class Booking
	{
		[Key]
		public int BookingId { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int RouteId { get; set; }
		public Route Route { get; set; }


	}
}
