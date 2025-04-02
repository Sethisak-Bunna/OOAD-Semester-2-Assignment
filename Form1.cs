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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phoneNumber = textBoxPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter both your name and phone number.");
                return;
            }

            Form2 form2 = new Form2(name, phoneNumber);
            form2.Show();
            this.Hide();
        }
    }
}