﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BookingHallAppDraft.Models;
using BookingHallAppDraft.Models.Database;

namespace BookingHallAppDraft.Controllers.api
{
    public class ClientsController : ApiController
    {
        // GET: Clients
        [HttpGet]
        public IEnumerable<Client> GetClients()
        {
            return ClientDAO.GetClients();
        }

        [HttpPost]
        public string Create(Client client)
        {
            ClientDAO.Create(client);
            return "Client Created";
        }

        [HttpDelete]
        public int Delete(int id)
        {
            ClientDAO.Delete(id);
            return 1;
        }

       
    }
}
