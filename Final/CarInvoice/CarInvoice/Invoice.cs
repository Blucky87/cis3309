using System.Runtime.InteropServices;

namespace CarInvoice
{
    public class Invoice
    {
        private Car car;
        private Customer customer;

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public double Discount;
        public string ID;

        public Invoice()
        {
            Car = new Car();
            Customer = new Customer();
            Discount = double.NaN;
            ID = string.Empty;
        }

        public Invoice(Car car, Customer customer, double discount, string id)
        {
            Car = car;
            Customer = customer;
            Discount = discount;
            ID = id;
        }

    }
}