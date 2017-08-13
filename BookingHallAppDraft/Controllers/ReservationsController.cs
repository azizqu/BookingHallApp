using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingHallAppDraft.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservations/ReservationsList
        public ActionResult ReservationsList()
        {
            //implement reservationDAO to get list + datatables w edit and delete
            return View();
        }

        // GET: Reservations/ReservationsAdd
        public ActionResult ReservationsAdd()
        {
            //send to reservationAdd form
            return View();
        }

        public ActionResult Book()
        {
            throw new NotImplementedException();
        }
    }
}