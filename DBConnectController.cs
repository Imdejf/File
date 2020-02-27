using System;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace MVC.Controllers
{
    public class DBConnectController : Controller
    {
        // GET: DBConnect
        public ActionResult Dbconnect()
        {
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=testt; CharSet=utf8";
            string query = "2INSERT INTO accounts(id, login, ..)VALUES(v1, v2, ..); ";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            OpenConnection(databaseConnection);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        string[] row = { reader.GetString(0), reader.GetString(1) };
                        MessageBox.Show(row[0]);
                        MessageBox.Show(row[1]);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                CloseConnection(databaseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return View();
        }

        private void OpenConnection(MySqlConnection databaseConnection)
        {
            databaseConnection.Open();
        }
        private void CloseConnection(MySqlConnection databaseConnection)
        {
            databaseConnection.Close();
        }
    }
}