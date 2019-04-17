using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab07_WindForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void Initialize()
        {
          
        }
        int counter = 0;

        private void Label1_Click(object sender, EventArgs e)
        {
            //add one to counter
            counter++;

            //display
            label1.Text = "You Clicked !!!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //add one to counter
            counter++;

            //display
            label1.Text = "You Clicked + " + counter + " times !!!";
        }
    }
}
