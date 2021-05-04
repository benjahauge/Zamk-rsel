﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Zamkørsel.Models
{
    public partial class Route
    {
        [Key]
        public int RouteId { get; set; }
        [Required]
        [StringLength(50)]
        public string StartPoint { get; set; }
        [Required]
        [StringLength(50)]
        public string EndPoint { get; set; }
        [Required]
        [StringLength(50)]
        public string ZealandLocation { get; set; }
        [Required]
        [StringLength(50)]
        public string PickUpPoint1 { get; set; }
        [StringLength(50)]
        public string PickUpPoint2 { get; set; }
        [StringLength(50)]
        public string PickUpPoint3 { get; set; }

    }
}