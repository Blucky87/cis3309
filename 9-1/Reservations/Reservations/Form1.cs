using System;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CancelButton = btnExit;
            AcceptButton = btnCalculate;

            //anon function event handler for when the form loads
            Load += (sender, args) =>
            {
                //set the arrival and departure dates to thier initial values
                txtArrivalDate.Text = DateTime.Now.ToShortDateString();
                txtDepartureDate.Text = DateTime.Now.AddDays(3).ToShortDateString();
            };

        }

        public bool IsValidData()
        {
            //set start and end dates for the range
            DateTime minDateTime = DateTime.Today;
            DateTime maxDateTime = DateTime.Today.AddYears(5);

            //run through each check, only performing the next if the previous was true
            return IsPresent(txtArrivalDate, "Arrival Date") &&
                   IsDateTime(txtArrivalDate, "Arrival Date") &&
                   IsWithinRange(txtArrivalDate, "Arrival Date", minDateTime, maxDateTime) &&
                   IsPresent(txtDepartureDate, "Departure Date") &&
                   IsDateTime(txtDepartureDate, "Departure Date") &&
                   IsWithinRange(txtDepartureDate, "Departure Date", minDateTime, maxDateTime);
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

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime date = new DateTime();

            bool isDateTime = DateTime.TryParse(textBox.Text, out date);

            if (!isDateTime)
                MessageBox.Show("Invalid " + name);
            
            return isDateTime;
        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            bool isWithinRange = false;
            DateTime date = DateTime.Now;

            bool validDate = DateTime.TryParse(textBox.Text, out date);

            if (validDate)
                isWithinRange = (date >= min) && (date <= max);

            //show message that there was a problem
            if (!isWithinRange)
                MessageBox.Show(String.Format("{} is out of range. Must be between {} and {}", name, min.ToShortDateString(), max.ToShortDateString()));

            return isWithinRange;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                DateTime arrival = DateTime.Parse(txtArrivalDate.Text);
                DateTime departure = DateTime.Parse(txtDepartureDate.Text);

                //do nothing if the dates are out of order
                if (arrival > departure) return;
               
                //expression for timespan days
                int numberOfNights = (departure - arrival).Days;

                //find total price
                decimal totalPrice = calcTotalPrice(arrival, departure);

                //find average price per night
                decimal avgPrice = totalPrice / numberOfNights;

                txtNights.Text = numberOfNights.ToString();
                txtTotalPrice.Text = totalPrice.ToString();
                txtAvgPrice.Text = avgPrice.ToString();
            }
            

        }

        private decimal calcTotalPrice(DateTime start, DateTime stop)
        {
            decimal priceTotal = 0.00m;

            //loop through the days and add appropriate amounts to total
            while (!start.Date.Equals(stop.Date))
            {
                //switch by the DayOfWeek enumeration
                switch (start.DayOfWeek)
                {
                    case DayOfWeek.Friday:
                        priceTotal += 150.00m;
                        break;
                    case DayOfWeek.Saturday:
                        priceTotal += 150.00m;
                        break;
                    default:
                        //sunday - thursday night
                        priceTotal += 120.00m;
                        break;
                }

                //increment by one day
                start = start.AddDays(1);
            }

            return priceTotal;
        }

    }
}