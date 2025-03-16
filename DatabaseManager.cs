using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Design_Pattern_Project
{
    public class DatabaseManager
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DrinkOrderDB"].ConnectionString;

        public DataTable GetDrinks()
        {
            DataTable drinkTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Drinks", conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(drinkTable);
                }
            }

            return drinkTable;
        }

        public DataTable GetToppings()
        {
            DataTable toppingTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Toppings", conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(toppingTable);
                }
            }

            return toppingTable;
        }
    }
}