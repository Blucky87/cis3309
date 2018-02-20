using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AcceptButton = btnCalculate;
            CancelButton = btnExit;

            Load += InitializeForm;
        }

        string[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};

        private List<Setting> settings;

        public void InitializeForm(object sender, EventArgs e)
        {
            //clear text boxes
            clearText();
            //build settings based off conversionTable array
            generateSettings();
            //add items to the combobox
            generateComboBoxItems();
            //set combobox to first setting
            applySettings(0);
        }

        public void applySettings(int index)
        {
            //change the labels to 
            lblFromLength.Text = settings[index].from;
            lblToLength.Text = settings[index].to;
        }

        public void generateComboBoxItems()
        {
            //get a list of just the converion members of each Setting in settings list
            cboConversions.DataSource = settings.Select(x => x.conversion).ToList();
        }

        public void generateSettings()
        {
            //reset settings list to empty
            settings = new List<Setting>();

            for (int i = 0; i <= conversionTable.GetUpperBound(0); i++)
            {
                //create new Setting to be built
                Setting tempSetting = new Setting();
                string currentString = String.Empty;

                for (int j = 0; j <= conversionTable.GetUpperBound(1); j++)
                {
                    currentString = conversionTable[i, j];

                    //add strings to Setting
                    switch (j)
                    {
                        case 0:
                            tempSetting.conversion = currentString;
                            break;
                        case 1:
                            tempSetting.from = currentString;
                            break;
                        case 2:
                            tempSetting.to = currentString;
                            break;
                        case 3:
                            Decimal.TryParse(currentString, out tempSetting.rate);
                            break;

                    }
                }

                //add built Setting to settings list
                settings.Add(tempSetting);
            }
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            applySettings(cboConversions.SelectedIndex);
            clearText();
            txtLength.Focus();
        }

        public void clearText()
        {
            txtLength.Text = "";
            lblCalculatedLength.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal input = 0m;
            bool validInput = Decimal.TryParse(txtLength.Text, out input);

            //check if the user enetered a valid decimal
            if (validInput)
            {
                //get the selected setting
                Setting selectedSetting = settings[cboConversions.SelectedIndex];
                //set the calculated text
                lblCalculatedLength.Text = (input * selectedSetting.rate).ToString();
            }
            
        }
    }

    //composite data type to wrap that multidimensional array for easy use
    public struct Setting
    {
        public string conversion;
        public string from;
        public string to;
        public decimal rate;
    }
}