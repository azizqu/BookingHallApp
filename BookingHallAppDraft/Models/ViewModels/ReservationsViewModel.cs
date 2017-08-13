using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models.ViewModels
{
    public class ReservationsViewModel
    {
        public List<Client> Clients { get; set; }

        public List<Hall> Halls { get; set; }

        
       
    }
}