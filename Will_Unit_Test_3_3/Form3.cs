using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Will_Unit_Test_3_3
{
    public partial class Form3 : Form
    {
        Form1 grandparent;
        Form2 parent;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form parent)
        {
            InitializeComponent();
            this.parent = (Form2)parent;
            this.grandparent = this.parent.getParent();


            //Will make the form the wrong color on purpose
            if (this.grandparent.redRadioButton.Checked == true) 
            {
                this.BackColor = Color.LemonChiffon;
            }
            else if (this.grandparent.yellowRadioButton.Checked == true)
            {
                this.BackColor = Color.SkyBlue;
            }
            else if (this.grandparent.blueRadioButton.Checked == true)
            {
                this.BackColor = Color.Tomato;
            }

            this.aboutLabel.Text = grandparent.aboutTextBox.Text;
            this.aboutLabel.Text = this.aboutLabel.Text.Replace('.', ' ');

            this.FormClosed += new FormClosedEventHandler(Form3__FormClosed);

        }

        private void Form3__FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
