using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateDelivery();
        }

        private void Size_Enter(object sender, EventArgs e)
        {

        }
        private void Toppings_Enter(object sender, EventArgs e)
        {

        }
        private void Crust_Type_Enter(object sender, EventArgs e)
        {

        }
        private void Delivery_Type_Enter(object sender, EventArgs e)
        {

        }
        private void Order_Summary_Enter(object sender, EventArgs e)
        {

        }

        float CalculateSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateSelectedToppingsPrice()
        {
            float Total = 0;
            if (chExtra_Cheese.Checked)
                Total += Convert.ToSingle(chExtra_Cheese.Tag);
            if(chOnion.Checked)
                Total += Convert.ToSingle(chOnion.Tag);
            if (chMushrooms.Checked)
                Total += Convert.ToSingle(chMushrooms.Tag);
            if (chOlives.Checked)
                Total += Convert.ToSingle(chOlives.Tag);
            if (chPeppers.Checked)
                Total += Convert.ToSingle(chPeppers.Tag);
            if (chTomatoes.Checked)
                Total += Convert.ToSingle(chTomatoes.Tag);
            
            return Total;
        }

        float CalculateSelectedCrustPrice()
        {
            if(rbThin_Crust.Checked)
                return Convert.ToSingle(rbThin_Crust.Tag);
            else
                return Convert.ToSingle(rbThick_Crust.Tag);
        }

        float CalculateSelectedDeliveryPrice()
        {
            if(rbRegular_Delivery.Checked)
                return Convert.ToSingle(rbRegular_Delivery.Tag);
            else
                return Convert.ToSingle(rbFast_Delivery.Tag);
        }

        float CalculateTotalPrice()
        {
            return CalculateSelectedSizePrice() + CalculateSelectedToppingsPrice()
                + CalculateSelectedCrustPrice() + CalculateSelectedDeliveryPrice();
        }
        void UpdateTotalPrice()
        {
            Total_Price.Text = "$" + CalculateTotalPrice().ToString("N2");
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if(rbSmall.Checked)
            {
                Order_Size.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                Order_Size.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                Order_Size.Text = "Large";
                return;
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThin_Crust.Checked)
                Order_Crust.Text = "Thin Crust";
            else
                Order_Crust.Text = "Thick Crust";
        }
        void UpdateDelivery()
        {
            UpdateTotalPrice();
            if (rbRegular_Delivery.Checked)
                Order_Delivery.Text = "Regular";
            else
                Order_Delivery.Text = "Fast";
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";
            if (chExtra_Cheese.Checked)
                Toppings += "Extra Cheese|";
            if (chOnion.Checked)
                Toppings += "Onion|";
            if (chMushrooms.Checked)
                Toppings += "Mushrooms|";
            if (chOlives.Checked)
                Toppings += "Olives|";
            if (chPeppers.Checked)
                Toppings += "Pepper|";
            if (chTomatoes.Checked)
                Toppings += "Tomatoes|";

            Order_Toppings.Text = Toppings=="" ? "" : Toppings.Substring(0, Toppings.Length - 1);
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chExtra_Cheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThin_Crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_Crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbRegular_Delivery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDelivery();
        }
        private void rbFast_Delivery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDelivery();
        }

        private void Reset_Form_Click(object sender, EventArgs e)
        {
            // defaul choices
            rbMedium.Checked = true;
            rbThin_Crust .Checked = true;
            rbRegular_Delivery.Checked = true;

            // reset toppings
            chExtra_Cheese.Checked = false;
            chOnion.Checked = false;
            chMushrooms.Checked = false;
            chOlives.Checked = false;
            chPeppers.Checked = false;
            chTomatoes.Checked = false;

            //enable groups
            Size.Enabled = true;
            Toppings.Enabled = true;
            Crust_Type.Enabled = true;
            Delivery_Type.Enabled = true;

            // reset button
            Order_Pizza.Enabled = true;
            Order_Pizza.BackColor = Color.DarkSlateBlue;
        }

        private void Order_Pizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information );
                Size.Enabled = false;
                Toppings.Enabled =false;
                Crust_Type.Enabled = false;
                Delivery_Type.Enabled = false;
                Order_Pizza.BackColor = Color.Gray;
                Order_Pizza.Enabled = false;
            }
        }


    }
}
