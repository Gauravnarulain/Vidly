﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "News Letter Subscription?")]
        public Boolean IsSubscribedToNewsLetter { get; set; }
        public MemberShip MemeShip { get; set; }

        [Required]
        [Display(Name = "Select MemberShip Type")]
        public byte MemberShipId { get; set; }
    }
}