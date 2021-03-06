﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
//Aziz 
namespace BookingHallAppDraft.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

    }
}