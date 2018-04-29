using System.Collections.Generic;
using System.Text;

namespace CarInvoice
{
    public class Feature
    {
        public string Desc { get; set; }
        public int ID { get; set; }


        public Feature(int id, string desc)
        {
            ID = id;
            Desc = desc;
        }

        public Feature()
        {
            ID = 0;
            Desc = string.Empty;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"Description: {Desc}");

            return stringBuilder.ToString();
        }
    }

    public class FeatureList : List<Feature>
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