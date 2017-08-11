using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingHallAppDraft.Models;
using BookingHallAppDraft.Models.Database;

namespace BookingHallAppDraft.Controllers
{
    public class HallsController : Controller
    {
        public ActionResult HallList()
        {
            var halls = HallDAO.GetHalls();

            return View(halls);
        }

        // Add Hall
        public ActionResult HallAdd()
        {
            return View();
        }

        //Save
        [HttpPost]
        public ActionResult Save(Hall hall)
        {
            if (!ModelState.IsValid)
                return View("HallAdd", hall);

            var hallId = int.Parse(Request["HallID"]);
            hall.HallID = hallId;

            if (hall.HallID == 0)
                HallDAO.Create(hall);
            else
            {
                HallDAO.Update(hall);
            }

            return RedirectToAction("HallList");
        }

        // Edit
        public ActionResult Edit(int id)
        {
            var hall = HallDAO.GetHall(id);
            if (hall == null)
                return HttpNotFound();

            return View("HallAdd", hall);
        }

        //Delete
        public ActionResult Delete(int id)
        {
            var hall = HallDAO.GetHall(id);
            if (hall == null)
                return HttpNotFound();
            HallDAO.Delete(hall);
            return RedirectToAction("HallList");
        }
    }
}