using System.Collections.Generic;
using System.Text;

namespace CarInvoice
{
    public class Model
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Model(int id, string image, string make, string name, int year)
        {
            ID = id;
            Image = image;
            Make = make;
            Name = name;
            Year = year;
        }

        public Model()
        {
            ID = 0;
            Image = string.Empty;
            Make = string.Empty;
            Name = string.Empty;
            Year = 0;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Make: {Make}");
            stringBuilder.AppendLine($"Year: {Year}");
            stringBuilder.AppendLine($"Image: {Image}");

            return stringBuilder.ToString();
        }
    }

    public class ModelList : List<Model>
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