using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        [Required]
        [Display(Name="Client ID")]
        public int ClientId { get; set; }
            public string ClientName { get; set; }
        [Required]
        [Display(Name = "Hall ID")]
        public int HallId { get; set; }
            public string HallName { get; set; }
        [Required]
        [DisplayFormat (DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set;}

    }
}