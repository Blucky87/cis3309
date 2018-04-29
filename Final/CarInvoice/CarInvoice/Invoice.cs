using System;
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
        public int ID;

        public Invoice()
        {
            Car = new Car();
            Customer = new Customer();
            Discount = 0.0;
            ID = 0;
        }

        public Invoice(Car car, Customer customer, double discount, int id)
        {
            Car = car;
            Customer = customer;
            Discount = discount;
            ID = id;
        }

    }
}