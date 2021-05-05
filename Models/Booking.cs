﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Zamkørsel.Models
{
	public partial class Booking
    {
		[Key]
		public int BookingId { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }

		[Column("Date_From", TypeName = "date")]
		public DateTime DateFrom { get; set; }
		[Column("Date_To", TypeName = "date")]
		public DateTime DateTo { get; set; }
	}
}