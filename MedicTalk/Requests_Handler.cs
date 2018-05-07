using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MedicTalk
{
    // This class will provide the functionality needed to view, and mark
    // requests as complete
    public static class Requests_Handler
    {

        static Mysql_Connect _MySQL = new Mysql_Connect();
        private static DataTable dataTable;

        public static DataTable DataTable { get => dataTable; set => dataTable = value; }


        /// <summary>
        /// Add request made by the resident into the database
        /// </summary>
        public static void Add_Request()
        {

        }

        /// <summary>
        /// Mark a request as complete so it no longer shows
        /// </summary>
        public static void Complete_Request()
        {

        }

        /// <summary>
        /// Show all requests
        /// </summary>
        public static void Show_Requests()
        {
            if (_MySQL.OpenConnection())
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(
                    "SELECT U.UID, U.FirstName, U.LastName, Res.Room, Res.Section, Req.TypeOf, Req.Choice, Req.RequestMadeAt, Req.Completed " +
                    "FROM NEWUsers U " +
                    "INNER JOIN NEWResidents Res ON U.UID = Res.UID " +
                    "INNER JOIN NEWRequests Req ON Res.UID = Req.UID;"
                    , _MySQL.connection);
                DataTable = new DataTable();
                mySqlDataAdapter.Fill(DataTable);
            }
            else
            {
                Console.WriteLine("Could not open connection");
            }
        }
    }
}
