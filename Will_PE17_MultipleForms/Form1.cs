using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is a windows forms application that demonstrates the use of multiple forms and their communication
//Author: Nick Will
//Restrictions: None
namespace Will_PE17_MultipleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
            this.lowTextBox.KeyPress += new KeyPressEventHandler(LowTextBox__KeyPress);
            this.highTextBox.KeyPress += new KeyPressEventHandler(HighTextBox__KeyPress);
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            try
            {
                lowNumber = Int32.Parse(lowTextBox.Text);
            }
            catch
            {
                MessageBox.Show("The low bound is not a valid number.");
            }

            try
            {
                highNumber = Int32.Parse(highTextBox.Text);
            }
            catch
            {
                MessageBox.Show("The upper bound is not a valid number.");
            }
            


            // if not a valid range
            if (lowNumber >= highNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

        private void LowTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void HighTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }
    }
}
