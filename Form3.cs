using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Pattern_Project
{
    public partial class Form3 : Form
    {
        private Order currentOrder;

        public Form3()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            DatabaseManager dbManager = new DatabaseManager();
            List<Order> orders = dbManager.GetOrders();

            listBox1.Items.Clear();
            decimal overallTotalPrice = 0;
            listBox1.Items.Add("Receipt:");
            listBox1.Items.Add("------------------------------");
            foreach (var order in orders)
            {

                listBox1.Items.Add(order.DrinkName);
                Debug.WriteLine($"Drink: {order.DrinkName}, Cost: {order.DrinkPrice}, ToppingPrice: {order.ToppingPrice}, TotalPrice: {order.TotalPrice}");


                overallTotalPrice += order.TotalPrice;
            }
            listBox1.Items.Add("------------------------------");

            labelTotal.Text = $"Total: ${overallTotalPrice:F2}";

            if (orders.Count == 0)
            {
                MessageBox.Show("No orders found.");
            }
        }
        private void buttonOkay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
