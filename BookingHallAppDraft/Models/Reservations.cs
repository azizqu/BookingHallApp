using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models
{
    public class Reservations
    {
        public int ReservationId { get; set; }

        public int ClientId { get; set; }

        public int HallId { get; set; }

        public DateTime Date { get; set;}

    }
}