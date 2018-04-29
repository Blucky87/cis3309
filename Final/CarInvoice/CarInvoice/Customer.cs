using System.Security.Policy;
using System.Text;

namespace CarInvoice
{
    public class Customer
    {
        public string Address;
        public string City;
        public string FirstName;
        public int ID;
        public string LastName;
        public string State;
        public string ZipCode;


        public Customer(string address, string city, string firstName, int id, string lastName, string state,
            string zipCode)
        {
            Address = address;
            City = city;
            FirstName = firstName;
            ID = id;
            LastName = lastName;
            State = state;
            ZipCode = zipCode;
        }

        public Customer()
        {
            Address = string.Empty;
            City = string.Empty;
            FirstName = string.Empty;
            ID = 0;
            LastName = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"First: {FirstName}");
            stringBuilder.AppendLine($"Last: {LastName}");
            stringBuilder.AppendLine($"Address:");
            stringBuilder.AppendLine($"\t{Address}");
            stringBuilder.AppendLine($"\t{City}, {State} {ZipCode}");

            return stringBuilder.ToString();
        }
    }
}