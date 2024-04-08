using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nameFormatter
{
    public partial class Form1 : Form
    {
        //Declaring fields
        public string firstName, middleName, lastName, title;

        private void buttonFMLName_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            middleName = textBoxMiddleName.Text;
            lastName = textBoxLastName.Text;

            labelDisplayOutput.Text = firstName + " " + middleName + " " + lastName;

        }

        private void buttonFLName_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;

            labelDisplayOutput.Text = firstName + " " + lastName;
        }

        private void buttonLFMTName_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            middleName = textBoxMiddleName.Text;
            lastName = textBoxLastName.Text;
            title = textBoxTitle.Text;

            labelDisplayOutput.Text = lastName + ", " + firstName + " " + middleName + ", " + title + ".";
        }

        private void buttonLFMName_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            middleName = textBoxMiddleName.Text;
            lastName = textBoxLastName.Text;

            labelDisplayOutput.Text = lastName + ", " + firstName + " " + middleName;
        }

        private void buttonLFName_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;

            labelDisplayOutput.Text = lastName + ", " + firstName;
        }

        private void buttonFullName_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            middleName = textBoxMiddleName.Text;
            lastName = textBoxLastName.Text;
            title = textBoxTitle.Text;

            labelDisplayOutput.Text = title + ". " + firstName + " " + middleName + " " + lastName;
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
