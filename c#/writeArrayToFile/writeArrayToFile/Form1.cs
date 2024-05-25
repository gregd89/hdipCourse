using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace writeArrayToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare Array
                int[] numbers = { 10, 20, 30, 40 };

                StreamWriter outputfile;

                outputfile = File.CreateText(@"C:\Users\GregDunne\Documents\College\2024\Principles of Programming\C# Programs\Files\values.txt");

                for (int index = 0; index < numbers.Length; index++)
                {
                    outputfile.WriteLine(numbers[index]);
                }
                outputfile.Close();

                MessageBox.Show("All Data Writing Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
