using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookingHallAppDraft.Models.Database
{
    public class MyDB
    {
        private static MyDB _instance;

        private SqlConnection _connection;

        private MyDB()
        {
            //update this line based on your SQL server URL (machine name, instance name and database name)
            // the option MultipleActiveResultSets=true allow your connection to have multiple dataset open at the same time
            _connection = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BookingHalls;Data Source=AZIZ-PC;MultipleActiveResultSets=true");
        }

        public static MyDB GetInstance()
        {
            if (_instance == null)
                _instance = new MyDB();
            return _instance;
        }

        public void ExecuteSql(string sql)
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();

            var command = _connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();

            _connection.Close();
        }


        public SqlDataReader ExecuteSelectSql(string sql)
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();

            var command = _connection.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();
        }

    }
}