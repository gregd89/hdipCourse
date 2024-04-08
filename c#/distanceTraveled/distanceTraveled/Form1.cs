using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanceTraveled
{
    public partial class Form1 : Form
    {

        public double speed;
        public double time;
        public double distance;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5Hrs_Click(object sender, EventArgs e)
        {
            speed = double.Parse(textBoxCarSpeed.Text);
            time = 5;
            distance = speed * time;

            outputLabel.Text = "The distance the car will travel in 5 hours is: " + distance + " miles.";
        }

        private void button8Hrs_Click(object sender, EventArgs e)
        {
            speed = double.Parse(textBoxCarSpeed.Text);
            time = 8;
            distance = speed * time;

            outputLabel.Text = "The distance the car will travel in 8 hours is: " + distance + " miles.";
        }

        private void button12Hrs_Click(object sender, EventArgs e)
        {
            speed = double.Parse(textBoxCarSpeed.Text);
            time = 12;
            distance = speed * time;

            outputLabel.Text = "The distance the car will travel in 12 hours is: " + distance + " miles.";
        }
    }
}
