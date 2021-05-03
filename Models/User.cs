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
	}
}
