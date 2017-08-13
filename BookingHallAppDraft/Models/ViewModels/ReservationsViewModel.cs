using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using BookingHallAppDraft.Models.Database;

namespace BookingHallAppDraft.Models.ViewModels
{
    public class ReservationsViewModel
    {
        public List<Client> Clients { get; set; }

        public Client Name{ get; set; }

        public List<Hall> Halls { get; set; }
       
    }
}