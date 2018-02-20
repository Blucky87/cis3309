using System;
using System.Text;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CancelButton = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //set default message
            string message = "Invalid email. Must contain a \'@\' symbol";

            //check if the textbox has a valid email entered in it
            if (isValidEmail(txtEmail))
            {
                //remove whitespace and split string into an array on '@' character
                string[] userInfo = txtEmail.Text.Trim().Split('@');

                //set message based on the email address information
                message = String.Format("User name: {0}\nDomain name: {1}", userInfo[0], userInfo[1]);
            }
            
            //show message
            MessageBox.Show(message);
        }

        private bool isValidEmail(TextBox textBox)
        {
            //check if valid email.
            return textBox.Text.Contains("@") && textBox.Text.Split('@').Length == 2;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            //capitalize the first character in the string
            string city = txtCity.Text[0].ToString().ToUpper() + txtCity.Text.Substring(1);
            //make sure state abrev is capital
            string state = txtState.Text.ToUpper();
            string zip = txtZipCode.Text;

            //create message based off text box information
            string message = String.Format("City, State, Zip: {0}, {1} {2}", city, state, zip);

            MessageBox.Show(message);
        }
    }
}
