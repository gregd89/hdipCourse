using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodChargeCalculator
{
    public partial class Form1 : Form
    {

        //Declare variables
        public double mealCost, tipAmount, salesTax, totalCost;

        private void calculateButton_Click(object sender, EventArgs e)
        {

            mealCost = double.Parse(textBoxMealCost.Text);
            tipAmount = mealCost * 0.15;
            salesTax = mealCost * 0.07;
            totalCost = mealCost + tipAmount + salesTax;

            labelDisplayCosts.Text = "The price of the meal was: " + mealCost + "\n The tip amount is: " + tipAmount + "\n The tax amount is: " + salesTax + "\n The total meal cost is: " +totalCost;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
