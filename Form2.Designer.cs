namespace Design_Pattern_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxToppings = new System.Windows.Forms.ComboBox();
            this.buttonRemoveFromCart = new System.Windows.Forms.Button();
            this.buttonOrder2 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.BackColor = System.Drawing.Color.White;
            this.comboBoxDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(572, 41);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(141, 24);
            this.comboBoxDrink.TabIndex = 0;
            this.comboBoxDrink.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrink_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drink Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toppings:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(414, 125);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add To Cart";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Location = new System.Drawing.Point(380, 186);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(361, 148);
            this.listBoxOrder.TabIndex = 5;
            this.listBoxOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxOrder_SelectedIndexChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(655, 306);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(58, 16);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total: 0$";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.Drink});
            this.dataGridViewMenu.GridColor = System.Drawing.Color.Purple;
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 117);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(303, 305);
            this.dataGridViewMenu.TabIndex = 7;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Drink
            // 
            this.Drink.HeaderText = "Drink";
            this.Drink.MinimumWidth = 6;
            this.Drink.Name = "Drink";
            this.Drink.Width = 125;
            // 
            // comboBoxToppings
            // 
            this.comboBoxToppings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToppings.FormattingEnabled = true;
            this.comboBoxToppings.Location = new System.Drawing.Point(572, 84);
            this.comboBoxToppings.Name = "comboBoxToppings";
            this.comboBoxToppings.Size = new System.Drawing.Size(121, 24);
            this.comboBoxToppings.TabIndex = 8;
            // 
            // buttonRemoveFromCart
            // 
            this.buttonRemoveFromCart.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemoveFromCart.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveFromCart.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRemoveFromCart.Location = new System.Drawing.Point(572, 125);
            this.buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            this.buttonRemoveFromCart.Size = new System.Drawing.Size(144, 40);
            this.buttonRemoveFromCart.TabIndex = 9;
            this.buttonRemoveFromCart.Text = "Remove From Cart";
            this.buttonRemoveFromCart.UseVisualStyleBackColor = false;
            // 
            // buttonOrder2
            // 
            this.buttonOrder2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonOrder2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder2.Location = new System.Drawing.Point(638, 340);
            this.buttonOrder2.Name = "buttonOrder2";
            this.buttonOrder2.Size = new System.Drawing.Size(75, 38);
            this.buttonOrder2.TabIndex = 10;
            this.buttonOrder2.Text = "Order";
            this.buttonOrder2.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCancel.Location = new System.Drawing.Point(638, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 38);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(12, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(44, 16);
            this.labelWelcome.TabIndex = 12;
            this.labelWelcome.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOrder2);
            this.Controls.Add(this.buttonRemoveFromCart);
            this.Controls.Add(this.comboBoxToppings);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDrink);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drink;
        private System.Windows.Forms.ComboBox comboBoxToppings;
        private System.Windows.Forms.Button buttonRemoveFromCart;
        private System.Windows.Forms.Button buttonOrder2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelWelcome;
    }
}

