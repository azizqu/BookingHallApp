using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models.ViewModels
{
    public class ReservationsViewModel
    {
        [Display (Name="Clients Information")]
        public List<Client> Clients { get; set; }

        public List<Hall> Halls { get; set; }

        
       
    }
}