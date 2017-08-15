using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models.Database
{
    public class HallDAO
    {
        public static void Update(Hall hall)
        {
            var sql = string.Format("Update Halls set HallName = '{0}' , MaxOccupancy = {1} Where HallID = {2}", hall.HallName, hall.MaxOccupancy, hall.HallID);
            MyDB.GetInstance().ExecuteSql(sql);

        }


        public static void Create(Hall hall)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("INSERT INTO Halls VALUES ('{0}' , '{1}')", hall.HallName, hall.MaxOccupancy);
            db.ExecuteSql(sql);
        }

        public static void Delete(Hall hall)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("Delete  From  Halls where HallID = {0}", hall.HallID);
            db.ExecuteSql(sql);
        }

        public static void Delete(int id)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("Delete From Halls where HallID = {0}", id);
            db.ExecuteSql(sql);
        }


        public static Hall GetHall(int id)
        {
            var db = MyDB.GetInstance();
            var sql =
                string.Format("Select * from Halls where HallID = {0}", id);
            var results = db.ExecuteSelectSql(sql);
            if (results.HasRows)
            {
                results.Read();
                return new Hall
                {
                    HallID = (int)results["HallID"],
                    HallName = results["HallName"].ToString(),
                    MaxOccupancy = (int)results["MaxOccupancy"]

                };
            }
            return null;
        }
        //
        public static List<Hall> GetHalls()
        {

            var halls = new List<Hall>();
            var results =
                MyDB.GetInstance().ExecuteSelectSql("select * from Halls");

            while (results.Read())
            {

                var hall = new Hall()
                {
                    HallID = (int)results["HallID"],
                    HallName = results["HallName"].ToString(),
                    MaxOccupancy = (int)results["MaxOccupancy"]


                };

                halls.Add(hall);

            }

            return halls;
        }
    }
}