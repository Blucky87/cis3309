using System.Collections.Generic;
using System.Text;

namespace CarInvoice
{
    public class Color
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Color(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Color()
        {
            ID = 0;
            Name = string.Empty;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"Name: {Name}");

            return stringBuilder.ToString();
        }
    }

    public class ColorList : List<Color>
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var package in this)
            {
                stringBuilder.AppendLine(package.ToString());
            }

            return stringBuilder.ToString();
        }
    }

}