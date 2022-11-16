using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Will_PE17_MultipleForms
{
    public partial class GameForm : Form
    {
        int answer;
        int nGuesses = 0;

        public GameForm()
        {
            InitializeComponent();
        }
        public GameForm(int lowNumber, int highNumber)
        {
            Random rand = new Random();
            answer = rand.Next(lowNumber, highNumber + 1);

            InitializeComponent();

            this.currentTextBox.KeyPress += new KeyPressEventHandler(CurrentTextBox__KeyPress);
            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.timer.Tick += new EventHandler(Timer__Tick);
            this.FormClosed += new FormClosedEventHandler(GameForm__FormClosed);

            this.timer.Start();
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            nGuesses++;

            int guess = Int32.Parse(currentTextBox.Text);

            if (guess < answer)
            {
                outputLabel.Text = "Your guess of " + guess + " was LOW";
            }
            else if (guess > answer)
            {
                outputLabel.Text = "Your guess of " + guess + " was HIGH";
            }
            else
            {
                timer.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                this.Close();
            }
        }

        private void CurrentTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar.PerformStep();

            if (progressBar.Value == 90)
            {
                timer.Stop();
                MessageBox.Show("Time is up! It's been 45 seconds!");
                this.Close();
            }
        }

        private void GameForm__FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
    }
}
