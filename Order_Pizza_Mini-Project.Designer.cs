namespace Win_Form_Project_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Size = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.Crust_Type = new System.Windows.Forms.GroupBox();
            this.rbThick_Crust = new System.Windows.Forms.RadioButton();
            this.rbThin_Crust = new System.Windows.Forms.RadioButton();
            this.Toppings = new System.Windows.Forms.GroupBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chPeppers = new System.Windows.Forms.CheckBox();
            this.chMushrooms = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chExtra_Cheese = new System.Windows.Forms.CheckBox();
            this.Delivery_Type = new System.Windows.Forms.GroupBox();
            this.rbFast_Delivery = new System.Windows.Forms.RadioButton();
            this.rbRegular_Delivery = new System.Windows.Forms.RadioButton();
            this.Order_Summary = new System.Windows.Forms.GroupBox();
            this.Order_Toppings = new System.Windows.Forms.Label();
            this.Order_Delivery = new System.Windows.Forms.Label();
            this.Order_Crust = new System.Windows.Forms.Label();
            this.Order_Size = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Label();
            this.Reset_Form = new System.Windows.Forms.Button();
            this.Order_Pizza = new System.Windows.Forms.Button();
            this.Size.SuspendLayout();
            this.Crust_Type.SuspendLayout();
            this.Toppings.SuspendLayout();
            this.Delivery_Type.SuspendLayout();
            this.Order_Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // Size
            // 
            this.Size.BackColor = System.Drawing.Color.Transparent;
            this.Size.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Size.Controls.Add(this.rbLarge);
            this.Size.Controls.Add(this.rbMedium);
            this.Size.Controls.Add(this.rbSmall);
            this.Size.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.ForeColor = System.Drawing.Color.White;
            this.Size.Location = new System.Drawing.Point(423, 120);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(186, 122);
            this.Size.TabIndex = 0;
            this.Size.TabStop = false;
            this.Size.Text = "Size";
            this.Size.Enter += new System.EventHandler(this.Size_Enter);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(15, 79);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "10";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(15, 53);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(93, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "7";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(15, 27);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(72, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // Crust_Type
            // 
            this.Crust_Type.BackColor = System.Drawing.Color.Transparent;
            this.Crust_Type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Crust_Type.Controls.Add(this.rbThick_Crust);
            this.Crust_Type.Controls.Add(this.rbThin_Crust);
            this.Crust_Type.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crust_Type.ForeColor = System.Drawing.Color.White;
            this.Crust_Type.Location = new System.Drawing.Point(423, 254);
            this.Crust_Type.Name = "Crust_Type";
            this.Crust_Type.Size = new System.Drawing.Size(186, 91);
            this.Crust_Type.TabIndex = 3;
            this.Crust_Type.TabStop = false;
            this.Crust_Type.Text = "Crust Type";
            this.Crust_Type.Enter += new System.EventHandler(this.Crust_Type_Enter);
            // 
            // rbThick_Crust
            // 
            this.rbThick_Crust.AutoSize = true;
            this.rbThick_Crust.Location = new System.Drawing.Point(15, 54);
            this.rbThick_Crust.Name = "rbThick_Crust";
            this.rbThick_Crust.Size = new System.Drawing.Size(118, 24);
            this.rbThick_Crust.TabIndex = 1;
            this.rbThick_Crust.Tag = "5";
            this.rbThick_Crust.Text = "Thick Crust";
            this.rbThick_Crust.UseVisualStyleBackColor = true;
            this.rbThick_Crust.CheckedChanged += new System.EventHandler(this.rbThick_Crust_CheckedChanged);
            // 
            // rbThin_Crust
            // 
            this.rbThin_Crust.AutoSize = true;
            this.rbThin_Crust.Checked = true;
            this.rbThin_Crust.Location = new System.Drawing.Point(15, 28);
            this.rbThin_Crust.Name = "rbThin_Crust";
            this.rbThin_Crust.Size = new System.Drawing.Size(110, 24);
            this.rbThin_Crust.TabIndex = 0;
            this.rbThin_Crust.TabStop = true;
            this.rbThin_Crust.Tag = "3";
            this.rbThin_Crust.Text = "Thin Crust";
            this.rbThin_Crust.UseVisualStyleBackColor = true;
            this.rbThin_Crust.CheckedChanged += new System.EventHandler(this.rbThin_Crust_CheckedChanged);
            // 
            // Toppings
            // 
            this.Toppings.BackColor = System.Drawing.Color.Transparent;
            this.Toppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Toppings.Controls.Add(this.chTomatoes);
            this.Toppings.Controls.Add(this.chOlives);
            this.Toppings.Controls.Add(this.chPeppers);
            this.Toppings.Controls.Add(this.chMushrooms);
            this.Toppings.Controls.Add(this.chOnion);
            this.Toppings.Controls.Add(this.chExtra_Cheese);
            this.Toppings.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toppings.ForeColor = System.Drawing.Color.White;
            this.Toppings.Location = new System.Drawing.Point(652, 120);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(268, 122);
            this.Toppings.TabIndex = 4;
            this.Toppings.TabStop = false;
            this.Toppings.Text = "Toppings";
            this.Toppings.Enter += new System.EventHandler(this.Toppings_Enter);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Location = new System.Drawing.Point(152, 80);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(109, 24);
            this.chTomatoes.TabIndex = 5;
            this.chTomatoes.Tag = ".50";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Location = new System.Drawing.Point(152, 54);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(78, 24);
            this.chOlives.TabIndex = 4;
            this.chOlives.Tag = ".75";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // chPeppers
            // 
            this.chPeppers.AutoSize = true;
            this.chPeppers.Location = new System.Drawing.Point(16, 80);
            this.chPeppers.Name = "chPeppers";
            this.chPeppers.Size = new System.Drawing.Size(95, 24);
            this.chPeppers.TabIndex = 3;
            this.chPeppers.Tag = ".60";
            this.chPeppers.Text = "Peppers";
            this.chPeppers.UseVisualStyleBackColor = true;
            this.chPeppers.CheckedChanged += new System.EventHandler(this.chPeppers_CheckedChanged);
            // 
            // chMushrooms
            // 
            this.chMushrooms.AutoSize = true;
            this.chMushrooms.Location = new System.Drawing.Point(16, 54);
            this.chMushrooms.Name = "chMushrooms";
            this.chMushrooms.Size = new System.Drawing.Size(125, 24);
            this.chMushrooms.TabIndex = 2;
            this.chMushrooms.Tag = "2";
            this.chMushrooms.Text = "Mushrooms";
            this.chMushrooms.UseVisualStyleBackColor = true;
            this.chMushrooms.CheckedChanged += new System.EventHandler(this.chMushrooms_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Location = new System.Drawing.Point(152, 28);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(77, 24);
            this.chOnion.TabIndex = 1;
            this.chOnion.Tag = ".50";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chExtra_Cheese
            // 
            this.chExtra_Cheese.AutoSize = true;
            this.chExtra_Cheese.Location = new System.Drawing.Point(16, 28);
            this.chExtra_Cheese.Name = "chExtra_Cheese";
            this.chExtra_Cheese.Size = new System.Drawing.Size(131, 24);
            this.chExtra_Cheese.TabIndex = 0;
            this.chExtra_Cheese.Tag = "1";
            this.chExtra_Cheese.Text = "Extra Cheese";
            this.chExtra_Cheese.UseVisualStyleBackColor = true;
            this.chExtra_Cheese.CheckedChanged += new System.EventHandler(this.chExtra_Cheese_CheckedChanged);
            // 
            // Delivery_Type
            // 
            this.Delivery_Type.BackColor = System.Drawing.Color.Transparent;
            this.Delivery_Type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delivery_Type.Controls.Add(this.rbFast_Delivery);
            this.Delivery_Type.Controls.Add(this.rbRegular_Delivery);
            this.Delivery_Type.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivery_Type.ForeColor = System.Drawing.Color.White;
            this.Delivery_Type.Location = new System.Drawing.Point(652, 254);
            this.Delivery_Type.Name = "Delivery_Type";
            this.Delivery_Type.Size = new System.Drawing.Size(268, 91);
            this.Delivery_Type.TabIndex = 4;
            this.Delivery_Type.TabStop = false;
            this.Delivery_Type.Text = "Delivery Type";
            this.Delivery_Type.Enter += new System.EventHandler(this.Delivery_Type_Enter);
            // 
            // rbFast_Delivery
            // 
            this.rbFast_Delivery.AutoSize = true;
            this.rbFast_Delivery.Location = new System.Drawing.Point(16, 54);
            this.rbFast_Delivery.Name = "rbFast_Delivery";
            this.rbFast_Delivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbFast_Delivery.Size = new System.Drawing.Size(129, 24);
            this.rbFast_Delivery.TabIndex = 1;
            this.rbFast_Delivery.Tag = "10";
            this.rbFast_Delivery.Text = "Fast Delivery";
            this.rbFast_Delivery.UseVisualStyleBackColor = true;
            this.rbFast_Delivery.CheckedChanged += new System.EventHandler(this.rbFast_Delivery_CheckedChanged);
            // 
            // rbRegular_Delivery
            // 
            this.rbRegular_Delivery.AutoSize = true;
            this.rbRegular_Delivery.Checked = true;
            this.rbRegular_Delivery.Location = new System.Drawing.Point(16, 28);
            this.rbRegular_Delivery.Name = "rbRegular_Delivery";
            this.rbRegular_Delivery.Size = new System.Drawing.Size(155, 24);
            this.rbRegular_Delivery.TabIndex = 0;
            this.rbRegular_Delivery.TabStop = true;
            this.rbRegular_Delivery.Tag = "5";
            this.rbRegular_Delivery.Text = "Regular Delivery";
            this.rbRegular_Delivery.UseVisualStyleBackColor = true;
            this.rbRegular_Delivery.CheckedChanged += new System.EventHandler(this.rbRegular_Delivery_CheckedChanged);
            // 
            // Order_Summary
            // 
            this.Order_Summary.BackColor = System.Drawing.Color.Transparent;
            this.Order_Summary.Controls.Add(this.Order_Toppings);
            this.Order_Summary.Controls.Add(this.Order_Delivery);
            this.Order_Summary.Controls.Add(this.Order_Crust);
            this.Order_Summary.Controls.Add(this.Order_Size);
            this.Order_Summary.Controls.Add(this.label4);
            this.Order_Summary.Controls.Add(this.label3);
            this.Order_Summary.Controls.Add(this.label2);
            this.Order_Summary.Controls.Add(this.label1);
            this.Order_Summary.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Summary.ForeColor = System.Drawing.Color.White;
            this.Order_Summary.Location = new System.Drawing.Point(423, 361);
            this.Order_Summary.Name = "Order_Summary";
            this.Order_Summary.Size = new System.Drawing.Size(497, 99);
            this.Order_Summary.TabIndex = 5;
            this.Order_Summary.TabStop = false;
            this.Order_Summary.Text = "Order Summary";
            this.Order_Summary.Enter += new System.EventHandler(this.Order_Summary_Enter);
            // 
            // Order_Toppings
            // 
            this.Order_Toppings.AutoSize = true;
            this.Order_Toppings.Location = new System.Drawing.Point(20, 70);
            this.Order_Toppings.Name = "Order_Toppings";
            this.Order_Toppings.Size = new System.Drawing.Size(0, 20);
            this.Order_Toppings.TabIndex = 7;
            // 
            // Order_Delivery
            // 
            this.Order_Delivery.AutoSize = true;
            this.Order_Delivery.Location = new System.Drawing.Point(360, 47);
            this.Order_Delivery.Name = "Order_Delivery";
            this.Order_Delivery.Size = new System.Drawing.Size(0, 20);
            this.Order_Delivery.TabIndex = 6;
            // 
            // Order_Crust
            // 
            this.Order_Crust.AutoSize = true;
            this.Order_Crust.Location = new System.Drawing.Point(360, 25);
            this.Order_Crust.Name = "Order_Crust";
            this.Order_Crust.Size = new System.Drawing.Size(0, 20);
            this.Order_Crust.TabIndex = 5;
            // 
            // Order_Size
            // 
            this.Order_Size.AutoSize = true;
            this.Order_Size.Location = new System.Drawing.Point(66, 25);
            this.Order_Size.Name = "Order_Size";
            this.Order_Size.Size = new System.Drawing.Size(0, 20);
            this.Order_Size.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crust Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toppings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Bk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(573, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Price:";
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSize = true;
            this.Total_Price.BackColor = System.Drawing.Color.Transparent;
            this.Total_Price.Font = new System.Drawing.Font("Roboto Bk", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price.ForeColor = System.Drawing.Color.LimeGreen;
            this.Total_Price.Location = new System.Drawing.Point(711, 470);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(39, 28);
            this.Total_Price.TabIndex = 7;
            this.Total_Price.Text = "$0";
            // 
            // Reset_Form
            // 
            this.Reset_Form.BackColor = System.Drawing.Color.Olive;
            this.Reset_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Form.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Form.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Reset_Form.Location = new System.Drawing.Point(493, 509);
            this.Reset_Form.Name = "Reset_Form";
            this.Reset_Form.Size = new System.Drawing.Size(130, 51);
            this.Reset_Form.TabIndex = 8;
            this.Reset_Form.Text = "Reset From";
            this.Reset_Form.UseVisualStyleBackColor = false;
            this.Reset_Form.Click += new System.EventHandler(this.Reset_Form_Click);
            // 
            // Order_Pizza
            // 
            this.Order_Pizza.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Order_Pizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_Pizza.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_Pizza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Order_Pizza.Location = new System.Drawing.Point(706, 509);
            this.Order_Pizza.Name = "Order_Pizza";
            this.Order_Pizza.Size = new System.Drawing.Size(130, 51);
            this.Order_Pizza.TabIndex = 9;
            this.Order_Pizza.Text = "Order Pizza";
            this.Order_Pizza.UseVisualStyleBackColor = false;
            this.Order_Pizza.Click += new System.EventHandler(this.Order_Pizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 578);
            this.Controls.Add(this.Order_Pizza);
            this.Controls.Add(this.Reset_Form);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Order_Summary);
            this.Controls.Add(this.Delivery_Type);
            this.Controls.Add(this.Toppings);
            this.Controls.Add(this.Crust_Type);
            this.Controls.Add(this.Size);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Tag = "5";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Size.ResumeLayout(false);
            this.Size.PerformLayout();
            this.Crust_Type.ResumeLayout(false);
            this.Crust_Type.PerformLayout();
            this.Toppings.ResumeLayout(false);
            this.Toppings.PerformLayout();
            this.Delivery_Type.ResumeLayout(false);
            this.Delivery_Type.PerformLayout();
            this.Order_Summary.ResumeLayout(false);
            this.Order_Summary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.GroupBox Crust_Type;
        private System.Windows.Forms.GroupBox Toppings;
        private System.Windows.Forms.RadioButton rbThick_Crust;
        private System.Windows.Forms.RadioButton rbThin_Crust;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chPeppers;
        private System.Windows.Forms.CheckBox chMushrooms;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chExtra_Cheese;
        private System.Windows.Forms.GroupBox Delivery_Type;
        private System.Windows.Forms.RadioButton rbFast_Delivery;
        private System.Windows.Forms.RadioButton rbRegular_Delivery;
        private System.Windows.Forms.GroupBox Order_Summary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Order_Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Order_Crust;
        private System.Windows.Forms.Label Order_Toppings;
        private System.Windows.Forms.Label Order_Delivery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Button Reset_Form;
        private System.Windows.Forms.Button Order_Pizza;
    }
}

