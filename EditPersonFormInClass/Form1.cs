using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPersonFormInClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //We don't have ok button quite yet :x
            //this.okButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emptyTextValidating(object sender, CancelEventArgs e)
        {
            TextBox nameTextBox = (TextBox)sender;

            //makes user unable to go to next field until the nameTextBox has been filled out.
            if(nameTextBox.Text.Length == 0)
            {
                // tell the user that it's not ok
                e.Cancel = true;
                nameTextBox.Tag = false;

                // error here
                this.errorProvider1.SetError(nameTextBox, "This field cannot be empty to continue with this form.");
            }
            else
            {
                e.Cancel = false;
                nameTextBox.Tag = true;
                Console.WriteLine("A value was passed in");

            }

            // if the text box is empty, then no validation
            // if its not empty its fine
        }
    }
}
