using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInvoice
{
    public class Package
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string ModelID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Package(int id, string description, string modelId, string name, double price)
        {
            ID = id;
            Description = description;
            ModelID = modelId;
            Name = name;
            Price = price;
        }

        public Package()
        {
            ID = 0;
            Description = string.Empty;
            ModelID = string.Empty;
            Name = string.Empty;
            Price = 0;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"ModelID: {ModelID}");
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Description: {Description}");
            stringBuilder.AppendLine($"Price: {0:DPrice}");

            return stringBuilder.ToString();
        }
    }

    public class PackageList : List<Package>
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