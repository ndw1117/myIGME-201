using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Will_Unit_Test_3_3
{
    public partial class Form2 : Form
    {
        public Form1 parent;
        public Form2()
        {
            InitializeComponent();

            this.timer.Start();
        }

        public Form2(Form parent)
        {
            InitializeComponent();

            this.parent = (Form1)parent;

            this.timer.Start();
            

            timer.Tick += new EventHandler(Timer__Tick);
            this.FormClosed += new FormClosedEventHandler(Form2__FormClosed);

            this.progressBar2.Visible = false;
        }

        public Form1 getParent()
        {
            return this.parent;
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            //There is a hidden progress bar to keep track of the actual wait time
            //The visible progress bar is supposed to fill up before the timer is actually done
            this.progressBar.PerformStep();
            this.progressBar2.PerformStep();

            if (progressBar.Value == 30)
            {
                statusLabel.Text = "Done! Enjoy your profile.";
                this.Refresh();
            }
            if (progressBar2.Value == 60)
            {
                timer.Stop();
                Form3 form3 = new Form3(this);
                this.Hide();
                form3.ShowDialog();
            }
        }

        private void Form2__FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            Application.Exit();
        }
    }
}
