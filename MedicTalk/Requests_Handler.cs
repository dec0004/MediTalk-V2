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








        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////

        /// <summary>
        /// Add food request made by the resident into the database
        /// </summary>
        public static void Add_Food(string foodName, string HotOrCold, string MealType)
        {

            // Insert the request into the table
            _MySQL.Insert_Request(
                "INSERT INTO NEWFoodRequests (UID, MealType, HotOrCold, MealName, TimeOfRequest, DateOfRequest) " +
                "Values (" + Mysql_User_Handler.User_ID + ", '" + MealType + "', '" + HotOrCold + "', '" + foodName + 
                "', NOW(), CURDATE());");


            //INSERT INTO NEWFoodRequests (UID, MealType, HotOrCold, MealName, TimeOfRequest, DateOfRequest) 
            //VALUES ("5", "Breakfast", "Hot", "Bacon and egg toast", NOW(), CURDATE());
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
            // TODO: Add a refresh button             
            if (_MySQL.OpenConnection())
            {
                // TODO: Seperate the requests list into 2 seperate request lists - 1 for food, and 1 for others.
                MySqlDataAdapter mySqlDataAdapter_Food = new MySqlDataAdapter(
                    "SELECT U.UID, U.FirstName, U.LastName, Res.Room, Res.Section, Req.MealType, Req.HotOrCold, Req.MealName, Req.DateOfRequest, Req.TimeOfRequest, Req.Completed FROM NEWUsers U " +
                    "INNER JOIN NEWResidents Res ON U.UID = Res.UID " +
                    "INNER JOIN NEWFoodRequests Req ON Res.UID = Req.UID;"
                    , _MySQL.connection);
                DataTable = new DataTable();
                mySqlDataAdapter_Food.Fill(DataTable);

            }
            else
            {
                Console.WriteLine("Could not open connection");
            }
        }
    }
}
