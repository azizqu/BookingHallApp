using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}