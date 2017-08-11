using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingHallAppDraft.Controllers
{
    public class HallsController : Controller
    {
        // GET: Halls/HallsList
        public ActionResult HallList()
        {
            return View();
        }
        // GET: Halls/HallAdd
        public ActionResult HallAdd()
        {
            return View();
        }
    }
}