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
    public partial class Form1 : Form
    {
        int buildAttempts = 0;

        public Form1()
        {
            InitializeComponent();

            nameTextBox.KeyPress += new KeyPressEventHandler(NameTextBox__KeyPress);
            toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip__ItemClicked);
            aboutTextBox.SelectionChanged += new EventHandler(AboutTextBox__SelectionChanged);
            buildButton.Click += new EventHandler(BuildButton__Click);
        }

        private void NameTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar >= 'N' && e.KeyChar <= 'm')
            {
                e.Handled = true;
            }
        }

        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = aboutTextBox.SelectionFont;
            if (selectionFont == null) //it will be null if there were multiple fonts in selection
            {
                selectionFont = aboutTextBox.Font; //will set all text in selection to defualt font and make bold
            }

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = aboutTextBox.SelectionFont;
            if (selectionFont == null) //it will be null if there were multiple fonts in selection
            {
                selectionFont = aboutTextBox.Font; //will set all text in selection to defualt font and make italic
            }

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = aboutTextBox.SelectionFont;
            if (selectionFont == null) //it will be null if there were multiple fonts in selection
            {
                selectionFont = aboutTextBox.Font; //will set all text in selection to defualt font and make underlined
            }

            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        private void ToolStrip__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.boldButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.boldButton;
            }
            else if (e.ClickedItem == this.italicsButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.italicsButton;
            }
            else if (e.ClickedItem == this.underlineButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.underlineButton;
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        private void SetSelectionFont(FontStyle fontStyle, Boolean bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = aboutTextBox.SelectionFont;

            if (selectionFont == null)
            {
                selectionFont = aboutTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.aboutTextBox.SelectionFont = newFont;
        }

        private void AboutTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if (this.aboutTextBox.SelectionFont != null)
            {
                this.boldButton.Checked = aboutTextBox.SelectionFont.Italic;
                this.italicsButton.Checked = aboutTextBox.SelectionFont.Underline;
                this.underlineButton.Checked = aboutTextBox.SelectionFont.Bold;
            }
        }

        private void BuildButton__Click(object sender, EventArgs e)
        {
            if (buildAttempts < 3) //Will show the annoying messagebox and unheck radio buttons 3 times before letting the user build profile
            {
                this.redRadioButton.Checked = false;
                this.yellowRadioButton.Checked = false;
                this.blueRadioButton.Checked = false;

                MessageBox.Show("You forgot to pick a background color for your profile!");

                this.buildAttempts++;
            }
            else
            {
                Form2 form2 = new Form2(this);
                this.Hide();
                form2.ShowDialog();
            }
        }
    }
}
