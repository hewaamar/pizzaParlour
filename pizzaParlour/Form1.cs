using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaParlour
{
    public partial class Form1 : Form
    {
        double basePrice = 7.00;
        double topping = 1.25;
        double toppingNumber;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                // declare topping number
                toppingNumber = Convert.ToDouble(toppingsInput.Text);
                // declare what the total price is
                total = basePrice + topping * topping;
                // show the price of the pizza with the specific number of toppings 
                toppingsOutput.Text = $"The price of a pizza with {toppingNumber} is {total.ToString ("$0.00")}";


            }
           
            catch

            {
                // tell user that they need to input a numerical value if they have not done that
                toppingsOutput.Text = "Please enter a numerical value.";
            }

        }
    }
}
