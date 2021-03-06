﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BookingHallAppDraft.Models;
using BookingHallAppDraft.Models.Database;
using BookingHallAppDraft.Models.ViewModels;

namespace BookingHallAppDraft.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservations/ReservationsList
        public ActionResult ReservationsList()
        {
            //implement reservationDAO to get list + datatables w edit and delete

            var list = ReservationDAO.GetReservations();
            return View(list);
        }

        // GET: Reservations/ReservationsAdd
        public ActionResult ReservationsAdd()
        {
            //send to reservationAdd form
            var clients = ClientDAO.GetClients();
            var halls = HallDAO.GetHalls();

            return View();
        }

        public ActionResult Book(Reservations reservations)
        {
            ReservationDAO.Create(reservations);
            if (!ModelState.IsValid)
                return View("ReservationsList", reservations);

            return RedirectToAction("ReservationsList");
        }
    }
}