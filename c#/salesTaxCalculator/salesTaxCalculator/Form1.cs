using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesTaxCalculator
{
    public partial class Form1 : Form
    {
        //Declare Variables
        public double amount, stateTax, countryTax, totalTax, totalCost;
        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            amount = double.Parse(textBoxPurchaseAmount.Text);
            stateTax = amount * 0.04;
            countryTax = amount * 0.02;
            totalTax = stateTax + countryTax;
            totalCost = totalTax + amount;

            outputLabel.Text = "The purchase amount is: " + amount + "\nThe State tax is: " + stateTax + "\nThe Country tax is: " + countryTax + "\nThe total sale cost is: " + totalCost;
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
