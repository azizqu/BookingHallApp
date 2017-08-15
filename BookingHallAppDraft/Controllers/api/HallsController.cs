using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookingHallAppDraft.Models;
using BookingHallAppDraft.Models.Database;

namespace BookingHallAppDraft.Controllers.api
{
    public class HallsController : ApiController
    {
        // GET: Clients
        [HttpGet]
        public IEnumerable<Hall> GetClients()
        {
            return HallDAO.GetHalls();
        }

        [HttpPost]
        public string Create(Hall hall)
        {
            HallDAO.Create(hall);
            return "Hall Created";
        }

        [HttpDelete]
        public int Delete(int id)
        {
            HallDAO.Delete(id);
            return 1;
        }
    }
}
