using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            webBrowser.ScriptErrorsSuppressed = true;

            //Bring the president picture box to the front
            this.presidentPictureBox.BringToFront();

            //Associate a CheckedChanged delegate method for each of the president radio buttons
            this.bhRadioButton.CheckedChanged += new EventHandler(BhRadioButton__CheckedChanged);
            this.frRadioButton.CheckedChanged += new EventHandler(FrRadioButton__CheckedChanged);
            this.wcRadioButton.CheckedChanged += new EventHandler(WcRadioButton__CheckedChanged);
            this.jbRadioButton.CheckedChanged += new EventHandler(JbRadioButton__CheckedChanged);
            this.fpRadioButton.CheckedChanged += new EventHandler(FpRadioButton__CheckedChanged);
            this.gbRadioButton.CheckedChanged += new EventHandler(GbRadioButton__CheckedChanged);
            this.boRadioButton.CheckedChanged += new EventHandler(BoRadioButton__CheckedChanged);
            this.jkRadioButton.CheckedChanged += new EventHandler(JkRadioButton__CheckedChanged);
            this.wmRadioButton.CheckedChanged += new EventHandler(WmRadioButton__CheckedChanged);
            this.rrRadioButton.CheckedChanged += new EventHandler(RrRadioButton__CheckedChanged);
            this.deRadioButton.CheckedChanged += new EventHandler(DeRadioButton__CheckedChanged);
            this.mvRadioButton.CheckedChanged += new EventHandler(MvRadioButton__CheckedChanged);
            this.gwRadioButton.CheckedChanged += new EventHandler(GwRadioButton__CheckedChanged);
            this.jaRadioButton.CheckedChanged += new EventHandler(JaRadioButton__CheckedChanged);
            this.trRadioButton.CheckedChanged += new EventHandler(TrRadioButton__CheckedChanged);
            this.tjRadioButton.CheckedChanged += new EventHandler(TjRadioButton__CheckedChanged);


            //Associate a KeyPress delegate method with the president text boxes
            this.bhTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.frTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.wcTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.jbTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.fpTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.gbTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.boTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.jkTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.wmTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.rrTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.deTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.mvTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.gwTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.jaTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.trTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);
            this.tjTextBox.KeyPress += new KeyPressEventHandler(presidentTextBox__KeyPress);

            //Associate a Validating delegate method for each of the text boxes
            this.bhTextBox.Validating += new CancelEventHandler(BhTextBox__Validating);
            this.frTextBox.Validating += new CancelEventHandler(FrTextBox__Validating);
            this.wcTextBox.Validating += new CancelEventHandler(WcTextBox__Validating);
            this.jbTextBox.Validating += new CancelEventHandler(JbTextBox__Validating);
            this.fpTextBox.Validating += new CancelEventHandler(FpTextBox__Validating);
            this.gbTextBox.Validating += new CancelEventHandler(GbTextBox__Validating);
            this.boTextBox.Validating += new CancelEventHandler(BoTextBox__Validating);
            this.jkTextBox.Validating += new CancelEventHandler(JkTextBox__Validating);
            this.wmTextBox.Validating += new CancelEventHandler(WmTextBox__Validating);
            this.rrTextBox.Validating += new CancelEventHandler(RrTextBox__Validating);
            this.deTextBox.Validating += new CancelEventHandler(DeTextBox__Validating);
            this.mvTextBox.Validating += new CancelEventHandler(MvTextBox__Validating);
            this.gwTextBox.Validating += new CancelEventHandler(GwTextBox__Validating);
            this.jaTextBox.Validating += new CancelEventHandler(JaTextBox__Validating);
            this.trTextBox.Validating += new CancelEventHandler(TrTextBox__Validating);
            this.tjTextBox.Validating += new CancelEventHandler(TjTextBox__Validating);

            //Associate a TextChanged event handler for each of the text boxes
            this.bhTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.frTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.wcTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.jbTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.fpTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.gbTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.boTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.jkTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.wmTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.rrTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.deTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.mvTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.gwTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.jaTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.trTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);
            this.tjTextBox.TextChanged += new EventHandler(bhTextBox__TextChanged);

            //Associate a CheckedChanged delegate method for each of the filter radio buttons
            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton__CheckedChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckedChanged);
            this.democraticrepublicanRadioButton.CheckedChanged += new EventHandler(DemocraticrepublicanRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__CheckedChanged);
            

            //Associate MouseHover delegate method for the president picture box
            this.presidentPictureBox.MouseHover += new EventHandler(PresidentPictureBox__MouseHover);

            //Associate a MouseLeave delegate method for the president picture box
            this.presidentPictureBox.MouseLeave += new EventHandler(PresidentPictureBox__MouseLeave);

            //Associate Click delegate method for the Exit button
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            //Associate Tick event for the timer
            this.timer.Tick += new EventHandler(Timer__Tick);
        }

        //presidentRadioButtons__CheckedChanged event handlers
        //change the picture box image location to the proper president image
        //change the url of the web browser
        //change the text of the web group box to be the new url
        private void BhRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
        }

        private void FrRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
        }
        private void WcRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
        }
        private void JbRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
        }
        private void FpRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
        }
        private void GbRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_W_Bush");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_W_Bush";
        }
        private void BoRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
        }
        private void JkRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
        }
        private void WmRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
        }
        private void RrRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
        }
        private void DeRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Dwight_Eisenhower");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_Eisenhower";
        }
        private void MvRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
        }
        private void GwRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
        }
        private void JaRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
        }
        private void TrRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
        }
        private void TjRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
            this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            this.webGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
        }

        //presidentTextBoxes__KeyPress event handler
        //if the key pressed is not a number or backspace, mark it as handled

        private void presidentTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        //presidentTextBoxes__Validating event handlers
        //if the number in the textbox is incorrect, set the ErrorProvider error and mark cancel as true and the textbox tag as false 
        //if the number in the textbox is correct, set the ErrorProvider error to null and mark cancel as false and the textbox tag as true
        private void BhTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("23"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            // any time the valid state of a control may have changed, revalidate whether to enable the Exit button
            ValidateAll();
        }

        private void FrTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("32"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void WcTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("42"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }
        private void JbTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("15"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void FpTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("14"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void GbTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("43"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void BoTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("44"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void JkTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("35"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void WmTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("25"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void RrTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("40"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void DeTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("34"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void MvTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("8"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void GwTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("1"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void JaTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("2"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void TrTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("26"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void TjTextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!tb.Text.Equals("3"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");

                // cancel the event (ie. do not move to the next field)
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }


        //presidentTextBoxes__TextChanged event handlers
        //if the timer is not running, start the timer
        //if the number in the textbox is incorrect, set the ErrorProvider error and mark the textbox tag as false 
        //if the number in the textbox is correct, set the ErrorProvider error to null and mark the textbox tag as true
        private void bhTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("23"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void FrTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("32"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void WcTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("42"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void JbTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("15"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void FpTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("14"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void GbTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("43"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void BoTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("44"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void JkTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("35"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void WmTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("25"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void RrTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("40"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void DeTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("34"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void MvTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("8"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void GwTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("1"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void JaTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("2"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void TrTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("26"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void tjTextBox__TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (this.timer.Enabled != true)
            {
                this.timer.Enabled = true;
            }

            if (!tb.Text.Equals("3"))
            {
                this.errorProvider.SetError(tb, "That is the wrong number.");
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }


        //filterRadioButtons__CheckedChanged event handler
        //hide the president radio buttons for the presidents that don't fit the filter, show the ones that do
        //select the radio button of whichever president is first in that filter category
        private void AllRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.bhRadioButton.Visible = true;
            this.frRadioButton.Visible = true;
            this.wcRadioButton.Visible = true;
            this.jbRadioButton.Visible = true;
            this.fpRadioButton.Visible = true;
            this.gbRadioButton.Visible = true;
            this.boRadioButton.Visible = true;
            this.jkRadioButton.Visible = true;
            this.wmRadioButton.Visible = true;
            this.rrRadioButton.Visible = true;
            this.deRadioButton.Visible = true;
            this.mvRadioButton.Visible = true;
            this.gwRadioButton.Visible = true;
            this.jaRadioButton.Visible = true;
            this.trRadioButton.Visible = true;
            this.tjRadioButton.Visible = true;

            this.bhRadioButton.Checked = true;    
        }

        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.frRadioButton.Visible = true;
            this.wcRadioButton.Visible = true;
            this.jbRadioButton.Visible = true;
            this.fpRadioButton.Visible = true;
            this.boRadioButton.Visible = true;
            this.jkRadioButton.Visible = true;
            this.mvRadioButton.Visible = true;

            this.bhRadioButton.Visible = false;
            this.gbRadioButton.Visible = false;
            this.wmRadioButton.Visible = false;
            this.rrRadioButton.Visible = false;
            this.deRadioButton.Visible = false;
            this.gwRadioButton.Visible = false;
            this.jaRadioButton.Visible = false;
            this.trRadioButton.Visible = false;
            this.tjRadioButton.Visible = false;

            this.frRadioButton.Checked = true;
        }

        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.bhRadioButton.Visible = true;
            this.gbRadioButton.Visible = true;
            this.wmRadioButton.Visible = true;
            this.rrRadioButton.Visible = true;
            this.deRadioButton.Visible = true;
            this.trRadioButton.Visible = true;

            this.frRadioButton.Visible = false;
            this.wcRadioButton.Visible = false;
            this.jbRadioButton.Visible = false;
            this.fpRadioButton.Visible = false;
            this.boRadioButton.Visible = false;
            this.jkRadioButton.Visible = false;
            this.mvRadioButton.Visible = false;
            this.gwRadioButton.Visible = false;
            this.jaRadioButton.Visible = false;
            this.tjRadioButton.Visible = false;

            this.bhRadioButton.Checked = true;
        }

        private void DemocraticrepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.tjRadioButton.Visible = true;

            this.bhRadioButton.Visible = false;
            this.frRadioButton.Visible = false;
            this.wcRadioButton.Visible = false;
            this.jbRadioButton.Visible = false;
            this.fpRadioButton.Visible = false;
            this.gbRadioButton.Visible = false;
            this.boRadioButton.Visible = false;
            this.jkRadioButton.Visible = false;
            this.wmRadioButton.Visible = false;
            this.rrRadioButton.Visible = false;
            this.deRadioButton.Visible = false;
            this.mvRadioButton.Visible = false;
            this.gwRadioButton.Visible = false;
            this.jaRadioButton.Visible = false;
            this.trRadioButton.Visible = false;

            this.tjRadioButton.Checked = true;
        }

        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.gwRadioButton.Visible = true;
            this.jaRadioButton.Visible = true;

            this.bhRadioButton.Visible = false;
            this.frRadioButton.Visible = false;
            this.wcRadioButton.Visible = false;
            this.jbRadioButton.Visible = false;
            this.fpRadioButton.Visible = false;
            this.gbRadioButton.Visible = false;
            this.boRadioButton.Visible = false;
            this.jkRadioButton.Visible = false;
            this.wmRadioButton.Visible = false;
            this.rrRadioButton.Visible = false;
            this.deRadioButton.Visible = false;
            this.mvRadioButton.Visible = false;
            this.trRadioButton.Visible = false;
            this.tjRadioButton.Visible = false;

            this.gwRadioButton.Checked = true;
        }

        //presidentPictureBox__MouseHover event handler
        //enlarge the picture
        //move it to the right location on the form
        private void PresidentPictureBox__MouseHover(object sender, EventArgs e)
        {
            this.presidentPictureBox.Scale(new SizeF(2, 2));
            this.presidentPictureBox.Location = new Point(12, 219);
        }

        //presidentPictureBox__MouseLeave event handler
        //shrink the picture
        //move it to the right location on the form
        private void PresidentPictureBox__MouseLeave(object sender, EventArgs e)
        {
            this.presidentPictureBox.Scale(new SizeF(.5F, .5F));
            this.presidentPictureBox.Location = new Point(12, 219);
        }

        //exitButton__Click event handler
        //Exit the application
        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Timer__Tick event handler
        //subtract from progress bar value
        //if progress bar is at zero, stop timer, reset text boxes, and fill progress bar
        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar.Value--;

            if(progressBar.Value == 0)
            {
                this.timer.Stop();
                this.progressBar.Value = 240;

                this.bhTextBox.Text = "0";
                this.frTextBox.Text = "0";
                this.wcTextBox.Text = "0";
                this.jbTextBox.Text = "0";
                this.fpTextBox.Text = "0";
                this.gbTextBox.Text = "0";
                this.boTextBox.Text = "0";
                this.jkTextBox.Text = "0";
                this.wmTextBox.Text = "0";
                this.rrTextBox.Text = "0";
                this.deTextBox.Text = "0";
                this.mvTextBox.Text = "0";
                this.gwTextBox.Text = "0";
                this.jaTextBox.Text = "0";
                this.trTextBox.Text = "0";
                this.tjTextBox.Text = "0";
            }
        }

        //ValidateAll method
        //If all textboxes have correct number, stop timer, change web browser to fireworks, enable exit button
        private void ValidateAll()
        {
            if ((bool)this.bhTextBox.Tag.Equals(true) &&
                (bool)this.frTextBox.Tag.Equals(true) &&
                (bool)this.wcTextBox.Tag.Equals(true) &&
                (bool)this.jbTextBox.Tag.Equals(true) &&
                (bool)this.fpTextBox.Tag.Equals(true) &&
                (bool)this.gbTextBox.Tag.Equals(true) &&
                (bool)this.boTextBox.Tag.Equals(true) &&
                (bool)this.jkTextBox.Tag.Equals(true) &&
                (bool)this.wmTextBox.Tag.Equals(true) &&
                (bool)this.rrTextBox.Tag.Equals(true) &&
                (bool)this.deTextBox.Tag.Equals(true) &&
                (bool)this.mvTextBox.Tag.Equals(true) &&
                (bool)this.gwTextBox.Tag.Equals(true) &&
                (bool)this.jaTextBox.Tag.Equals(true) &&
                (bool)this.trTextBox.Tag.Equals(true) &&
                (bool)this.tjTextBox.Tag.Equals(true)
               )
            {
                this.timer.Stop();
                this.webBrowser.Navigate("https://www.youtube.com/embed/18212B4yfLg?autoplay=1");
                this.exitButton.Enabled = true;

            }
        }
    }
}
