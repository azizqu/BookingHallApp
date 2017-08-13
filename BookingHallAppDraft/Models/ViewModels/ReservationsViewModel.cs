using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace BookingHallAppDraft.Models.ViewModels
{
    public class ReservationsViewModel
    {
        [Display (Name="Clients Information")]
        public List<Client> Clients { get; set; }
        [Display (Name = "Halls Information")]
        public List<Reservations> Halls { get; set; }

        
       
    }
}