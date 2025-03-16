using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project
{
    public partial class Form2 : Form
    {
        private string userName;
        private string userPhone;

        // Updated constructor to accept name and phone number
        public Form2(string name, string phone)
        {
            InitializeComponent();
            userName = name;
            userPhone = phone;

            // Optionally display user information
            labelWelcome.Text = $"Welcome, {userName}!";
            InitializeDrinkMenu();
            InitializeToppings();
        }

        private void InitializeDrinkMenu()
        {
            DatabaseManager dbManager = new DatabaseManager();
            DataTable drinkMenu = dbManager.GetDrinks(); // Load drinks from the database

            dataGridViewMenu.DataSource = drinkMenu;

            // Populate ComboBox with drink names
            foreach (DataRow row in drinkMenu.Rows)
            {
                comboBoxDrink.Items.Add(row["Name"].ToString());
            }
        }

        private void InitializeToppings()
        {
            DatabaseManager dbManager = new DatabaseManager();
            DataTable toppingMenu = dbManager.GetToppings(); // Load toppings from the database

            comboBoxToppings.Items.Clear(); // Clear existing items
            foreach (DataRow row in toppingMenu.Rows)
            {
                comboBoxToppings.Items.Add(row["Name"].ToString());
            }
            comboBoxToppings.SelectedIndex = 0; // Default selection
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDrink.SelectedItem != null)
            {
                string selectedDrink = comboBoxDrink.SelectedItem.ToString();
                Drink drink = DrinkFactory.CreateDrink(selectedDrink);

                // Check selected topping and add its cost
                string selectedTopping = comboBoxToppings.SelectedItem.ToString();
                if (selectedTopping != "None")
                {
                    switch (selectedTopping.ToLower())
                    {
                        case "boba":
                            drink = new BobaDecorator(drink);
                            break;
                        case "jelly":
                            drink = new JellyDecorator(drink);
                            break;
                    }
                }

                // Add the drink to the order manager
                OrderManager.Instance.AddDrink(drink);
                double total = OrderManager.Instance.GetTotalCost(); // Include topping cost
                labelTotal.Text = $"Total: ${total:F2}";
                listBoxOrder.Items.Add(drink.Description);

                // Observer notification
                new OrderNotifier().Update("Order placed successfully!");
            }
            else
            {
                MessageBox.Show("Please select a drink.");
            }
        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedItem != null)
            {
                // Display or process the selected drink
                MessageBox.Show($"You selected: {listBoxOrder.SelectedItem}");
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if needed
        }

        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle drink selection changes if needed
        }
    }
}
