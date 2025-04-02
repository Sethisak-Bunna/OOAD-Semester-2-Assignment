using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Design_Pattern_Project;
using System.Diagnostics;

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


   
    public List<Design_Pattern_Project.Order> GetOrders()
    {
        List<Design_Pattern_Project.Order> orders = new List<Design_Pattern_Project.Order>();

        string connectionString = "Server=localhost;Database=DrinkOrderDB;Uid=root;Pwd=1234;";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT DrinkName, DrinkPrice, Toppings, ToppingPrice, TotalPrice FROM Orders";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string drinkName = reader["DrinkName"].ToString();
                        decimal drinkPrice = (decimal)reader["DrinkPrice"];
                        string toppings = reader["Toppings"].ToString();
                        decimal toppingPrice = (decimal)reader["ToppingPrice"];
                        decimal totalPrice = (decimal)reader["TotalPrice"];

                        orders.Add(new Design_Pattern_Project.Order
                        {


                            Toppings = toppings,

                            TotalPrice = totalPrice,
                            DrinkName = reader["DrinkName"].ToString(),
                            DrinkPrice = reader.IsDBNull(reader.GetOrdinal("DrinkPrice")) ? 0 : (decimal)reader["DrinkPrice"],
                            ToppingPrice = reader.IsDBNull(reader.GetOrdinal("ToppingPrice")) ? 0 : (decimal)reader["ToppingPrice"]
                        });
                    }
                }
            }
        }

        return orders;
    }

    public void InsertOrder(string drinkName, decimal drinkPrice, string toppings, decimal toppingPrice, decimal totalPrice)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO Orders (DrinkName, DrinkPrice, Toppings, ToppingPrice, TotalPrice) VALUES (@drinkName, @drinkPrice, @toppings, @toppingPrice, @totalPrice)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@drinkName", drinkName);
                cmd.Parameters.AddWithValue("@drinkPrice", drinkPrice);
                cmd.Parameters.AddWithValue("@toppings", toppings);
                cmd.Parameters.AddWithValue("@toppingPrice", toppingPrice);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd.ExecuteNonQuery();
            }
        }
    }
}