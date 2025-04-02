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
        private Dictionary<string, decimal> orderItems = new Dictionary<string, decimal>();
        private decimal totalPrice = 0.0m;
        public Form2(string name, string phone)
        {
            InitializeComponent();
            userName = name;
            userPhone = phone;

            labelWelcome.Text = $"Welcome, {userName}!";
            InitializeDrinkMenu();
            InitializeToppings();
        }

        private void InitializeDrinkMenu()
        {
            DatabaseManager dbManager = new DatabaseManager();
            DataTable drinkMenu = dbManager.GetDrinks(); 

            dataGridViewMenu.DataSource = drinkMenu;
            foreach (DataRow row in drinkMenu.Rows)
            {
                comboBoxDrink.Items.Add(row["Name"].ToString());
            }
        }

        private void InitializeToppings()
        {
            DatabaseManager dbManager = new DatabaseManager();
            DataTable toppingMenu = dbManager.GetToppings();

            comboBoxToppings.Items.Clear();
            foreach (DataRow row in toppingMenu.Rows)
            {
                comboBoxToppings.Items.Add(row["Name"].ToString());
            }
            comboBoxToppings.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDrink.SelectedItem != null)
            {
                string selectedDrink = comboBoxDrink.SelectedItem.ToString();
                Drink drink = DrinkFactory.CreateDrink(selectedDrink);

                string selectedTopping = comboBoxToppings.SelectedItem.ToString();
                decimal toppingPrice = 0.0m;

                if (selectedTopping != "None")
                {
                    switch (selectedTopping.ToLower())
                    {
                        case "boba":
                            drink = new BobaDecorator(drink);
                            toppingPrice = 0.0m;
                            break;
                        case "jelly":
                            drink = new JellyDecorator(drink);
                            toppingPrice = 0.0m;
                            break;
                    }
                }

                decimal itemPrice = (decimal)drink.Cost + toppingPrice; 
                totalPrice += itemPrice;

                labelTotal.Text = $"Total: ${totalPrice:F2}";

                string drinkDescription = $"{drink.Description} - ${itemPrice:F2}"; 
                listBoxOrder.Items.Add(drinkDescription);
                orderItems[drinkDescription] = itemPrice; 
            }
            else
            {
                MessageBox.Show("Please select a drink.");
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (listBoxOrder.Items.Count == 0)
            {
                MessageBox.Show("Please add drinks to your order before proceeding.");
                return;
            }

            DatabaseManager dbManager = new DatabaseManager();

            foreach (var item in listBoxOrder.Items)
            {
                string drinkName = item.ToString();
                Drink drink = DrinkFactory.CreateDrink(drinkName);
                decimal drinkPrice = (decimal)drink.Cost;

                string selectedTopping = comboBoxToppings.SelectedItem?.ToString() ?? "None";
                decimal toppingPrice = 0;

                if (selectedTopping != "None")
                {
                    switch (selectedTopping.ToLower())
                    {
                        case "boba":
                            toppingPrice = 0.0m;
                            break;
                        case "jelly":
                            toppingPrice = 0.0m;
                            break;
                    }
                }

                decimal totalPrice = drinkPrice + toppingPrice;
                dbManager.InsertOrder(drinkName, drinkPrice, selectedTopping, toppingPrice, totalPrice);
            }

            MessageBox.Show("All orders have been placed successfully!");

            listBoxOrder.Items.Clear();
            labelTotal.Text = "Total: $0.00";

            // Navigate to Form3
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxOrder.Items.Count > 0)
            {
                listBoxOrder.Items.Clear();
                orderItems.Clear();
                totalPrice = 0.0m;
                labelTotal.Text = $"Total: ${totalPrice:F2}";

                MessageBox.Show("All items have been removed.");
            }
            else
            {
                MessageBox.Show("There are no items to remove.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to cancel the order and go back to the main menu?",
                "Cancel Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                // Close the current form
                this.Hide(); 
                Form1 form1 = new Form1(); 
                form1.Show(); 
            }
        }
        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedItem != null)
            {
                MessageBox.Show($"You selected: {listBoxOrder.SelectedItem}");
            }
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBoxDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
