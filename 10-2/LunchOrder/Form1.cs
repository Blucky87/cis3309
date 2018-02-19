using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        private List<Setting> settings;
        private Setting currentSetting;

        public Form1()
        {
            InitializeComponent();

            CancelButton = btnExit;
            AcceptButton = btnPlaceOrder;

            Load += InitializeForm;
        }

        private void InitializeForm(object sender, EventArgs e)
        {
            generateSettings();
            generateMainCourse();
            applySettings(0);
        }

        private void generateMainCourse()
        {
            List<RadioButton> radioButtons = new List<RadioButton>{ radioButton1, radioButton2, radioButton3};

            for (int i = 0; i < radioButtons.Count; i++)
            {
                radioButtons[i].Text = String.Format("{0} - ${1}", settings[i].menuItemText, settings[i].itemPrice);
            }
        }

        private void applySettings(int index)
        {
            currentSetting = settings[index];
            changeAddons(currentSetting);
        }

        private void generateSettings()
        {
            settings = new List<Setting>();

            settings.Add(new Setting("Hamburger", 6.95m,
                    "Lettice, tomato, and onions",
                    "Catsup, mustard, and mayo",
                    "French fries",
                    0.75m));

            settings.Add(new Setting("Pizza", 5.95m,
                    "Pepperoni",
                    "Sausage",
                    "Olives",
                    0.50m));

            settings.Add(new Setting("Salad", 4.95m,
                    "Croutons",
                    "Bacon Bits",
                    "Bread Sticks",
                    0.25m));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearTotals()
        {
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";
        }

        private void ClearAddons()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void changeAddons(Setting setting)
        {
            groupBox2.Text = String.Format("Add-on items(${0}/each)", setting.addonPrice);
            checkBox1.Text = setting.addon1Text;
            checkBox2.Text = setting.addon2Text;
            checkBox3.Text = setting.addon3Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            applySettings(0);
            ClearTotals();
            ClearAddons();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            applySettings(1);
            ClearTotals();
            ClearAddons();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            applySettings(2);
            ClearTotals();
            ClearAddons();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox> { checkBox1, checkBox2, checkBox3 };
            int numberOfAddons = checkBoxes.Count(x => x.Checked);

            decimal addonTotal = currentSetting.addonPrice * numberOfAddons;
            decimal subtotal = currentSetting.itemPrice + addonTotal;
            decimal total = Math.Round(Decimal.Multiply(subtotal, 1.0775m), 2);
            decimal tax = Math.Round(total - subtotal, 2);
            
            lblSubtotal.Text = String.Format("${0}", subtotal.ToString());
            lblSalesTax.Text = String.Format("${0}", tax.ToString());
            lblOrderTotal.Text = String.Format("${0}", total.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
    }

    public class Setting
    {
        public Setting(string menuItem, decimal price, string chk1, string chk2, string chk3, decimal addon)
        {
            menuItemText = menuItem;
            itemPrice = price;
            addon1Text = chk1;
            addon2Text = chk2;
            addon3Text = chk3;
            addonPrice = addon;
        }

        public string menuItemText;
        public decimal itemPrice;
        public string addon1Text;
        public string addon2Text;
        public string addon3Text;
        public decimal addonPrice;

    }
}