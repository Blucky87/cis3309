using System.Text;

namespace Products
{
    public class Product
    {
        public string ID;
        public string Description;
        public double Price;
        public int Quantity;


        public Product()
        {
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"Description: {Description}");
            stringBuilder.AppendLine($"Price: ${Price}");
            stringBuilder.AppendLine($"Quantity: {Quantity}");

            return stringBuilder.ToString();
        }
    }
}