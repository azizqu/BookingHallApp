using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//Asad
namespace BookingHallAppDraft.Models
{
    public class Hall
    {
       
        public int HallID { get; set; }

        [Required(ErrorMessage = "Hall Name is required")]
        public string HallName { get; set; }


        [Required(ErrorMessage = "Max Occupancy is required")]
        [Range(50,500, ErrorMessage = "Occupancy must be between 50 and 500")]
        public int MaxOccupancy { get; set; }
    }
}
