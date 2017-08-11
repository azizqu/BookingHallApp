using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingHallAppDraft.Models;
using BookingHallAppDraft.Models.Database;

namespace BookingHallAppDraft.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients/ClientList
        public ActionResult ClientList()
        {
            var clients = ClientDAO.GetClients();

            return View(clients);
        }

        //GET: Clients/ClientsAdd
        public ActionResult ClientAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Client client)
        {
            if (!ModelState.IsValid)
                return View("ClientAdd", client);

            var clientId = int.Parse(Request["clientID"]);
            client.ClientId = clientId;

            if (client.ClientId == 0)
                ClientDAO.Create(client);
            else
            {
                ClientDAO.Update(client);
            }

            return RedirectToAction("ClientList");
        }

        public ActionResult Edit(int id)
        {
            var client = ClientDAO.GetClient(id);
            if (client == null)
                return HttpNotFound();
            
            return View("ClientAdd", client);
        }
        public ActionResult Delete(int id)
        {

            return View();
        }
    }
}