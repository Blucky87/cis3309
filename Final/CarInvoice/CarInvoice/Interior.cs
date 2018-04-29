using System.Collections.Generic;
using System.Text;

namespace CarInvoice
{
    public class Interior
    {
        public string Color { get; set; }
        public int ID { get; set; }


        public Interior(int id, string color)
        {
            ID = id;
            Color = color;
        }

        public Interior()
        {
            ID = 0;
            Color = string.Empty;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"ID: {ID}");
            stringBuilder.AppendLine($"Color: {Color}");

            return stringBuilder.ToString();
        }
    }

    public class InteriorList : List<Interior>
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            ForEach(x => stringBuilder.AppendLine(x.ToString()));

            return stringBuilder.ToString();
        }
    }
}