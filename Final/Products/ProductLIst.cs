using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductList : List<Product>
    {
        public double CalcInventory()
        {
            double value = 0;
            for (int i = 0; i < this.Count; i++)
            {
                value += this[i].Price * this[i].Quantity;
            }

            return value;
        }

        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                stringBuilder.Append(this[i]);
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}