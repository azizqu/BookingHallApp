using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using BookingHallAppDraft.Models;
using BookingHallAppDraft.Models.Database;

namespace BookingHallAppDraft.Controllers.api
{
    public class ClientsController : ApiController
    {
        // GET: Clients
        [System.Web.Mvc.HttpGet]
        public IEnumerable<Client> GetClients()
        {
            return ClientDAO.GetClients();
        }

        [System.Web.Mvc.HttpPost]
        public string Create(Client client)
        {
            ClientDAO.Create(client);
            return "Client Created";
        }

        [System.Web.Http.HttpDelete]
        public void Delete(int id)
        {
            var client = ClientDAO.GetClient(id);
            ClientDAO.Delete(client);
        }

       
    }
}
