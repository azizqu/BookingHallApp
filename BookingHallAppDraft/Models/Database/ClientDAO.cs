using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models.Database
{
    public class ClientDAO
    {
        public static void Create(Client client)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("INSERT INTO Clients VALUES ('{0}' , '{1}', {2})", client.Name, client.Email, client.Phone);
            db.ExecuteSql(sql);
        }

        public static Client GetClient(int id)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("Select * from Clients where ClientID = {0}", id);
            var results = db.ExecuteSelectSql(sql);
            if (results.HasRows)
            {
                results.Read();
                return new Client
                {
                    ClientId = (int)results["ClientID"],
                    Name = results["Name"].ToString(),
                    Email = results["Email"].ToString(),
                    Phone = results["Phone"].ToString()

                };
            }
            return null;
        }

        public static List<Client> GetClients()
        {

            var clients = new List<Client>();
            var results =
                MyDB.GetInstance().ExecuteSelectSql("select * from Clients");

            while (results.Read())
            {

                var client = new Client()
                {
                    ClientId = (int)results["ClientID"],
                    Name = results["Name"].ToString(),
                    Email = results["Email"].ToString(),
                    Phone = results["Phone"].ToString()

                };

                clients.Add(client);

            }

            return clients;
        }

        public static void Update(Client client)
        {
            var sql = string.Format("Update Clients  set Name = '{0}'" +
                                    ", Email = '{1}' ,  Phone = '{2}'", client.Name, client.Email, client.Phone);
            MyDB.GetInstance().ExecuteSql(sql);

        }
    }
}