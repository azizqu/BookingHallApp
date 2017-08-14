﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using BookingHallAppDraft.Models.ViewModels;

namespace BookingHallAppDraft.Models.Database
{
    public class ReservationDAO
    {
        public static void Update(Reservations reservations)
        {
            var sql = string.Format("Update Reservations set ClientID = '{0}' , HallID = {1}, Date = '{2} Where ResID = {3}", reservations.ClientId, reservations.HallId, reservations.Date, reservations.ReservationId);
            MyDB.GetInstance().ExecuteSql(sql);

        }


        public static void Create(Reservations reservations)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("INSERT INTO Reservations VALUES ('{0}' , '{1}', '{2}')", reservations.ClientId, reservations.HallId, reservations.Date);
            db.ExecuteSql(sql);
        }

        public static void Delete(Reservations reservations)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("Delete  From  Reservations where ResID = {0}", reservations.ReservationId);
            db.ExecuteSql(sql);
        }


        public static Reservations GetReservation(Reservations reservations)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("Select * from Reservations where ResID = {0}", reservations.ReservationId);
            var results = db.ExecuteSelectSql(sql);
            if (results.HasRows)
            {
                results.Read();
                return new Reservations
                {
                    ReservationId = (int)results["ResID"],
                    ClientId = (int)results["ClientID"],
                     HallId= (int)results["HallID"],
                    Date = (DateTime)results["Date"]
                };
            }
            return null;
        }
        //
        public static List<Reservations> GetReservations()
        {

            var reservations= new List<Reservations>();
            var results =
                MyDB.GetInstance().ExecuteSelectSql("select * from Reservations");

            while (results.Read())
            {

                var reservation = new Reservations()
                {
                    ReservationId = (int)results["ResID"],
                    ClientId = (int)results["ClientID"],
                    HallId = (int)results["HallID"],
                    Date = (DateTime)results["Date"]

                };

                reservations.Add(reservation);

            }

            return reservations;
        }

        public static Reservations GetAvailability(Hall hall,  Hall date)
        {
            
                var db = MyDB.GetInstance();
                var sql =
                    string.Format("Select * from Reservations where HallID = {0} AND Date ={1}", hall.HallID, date);
                var results = db.ExecuteSelectSql(sql);
                if (results.HasRows)
                {
                    results.Read();
                    return new Reservations
                    {
                        ReservationId = (int)results["ResID"],
                        ClientId = (int)results["ClientID"],
                        HallId = (int)results["HallID"],
                        Date = (DateTime)results["Date"]
                    };
                }
                return null;
            


    }


    }
}