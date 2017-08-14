using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingHallAppDraft.Models.ViewModels
{
    public class ReservationsViewModel
    {
        [Display (Name="Clients Information")]
        public List<Client> Clients { get; set; }
        
        public Client ClientName { get; set; }
        
        public Hall HallName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Reservations Date { get; set; }

        public List<Hall> Halls { get; set; }


        
       
    }
}