using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace languageTranslator
{
    public partial class translateForm : Form
    {
        public translateForm()
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

        private void irishButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Maidin Maith";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos Dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Morgan";
        }
    }
}
