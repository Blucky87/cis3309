namespace ProductRWLuckenbillB
{
    class TShirt : Apparel
    {
        public string Size;

        public TShirt(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer, string size)
            : base(type, id, desc, price, qty, material, color, manufacturer)
        {
            Size = size;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{Size}";
        }

        public override string ToString()
        {
            return getDisplayText("\n");
        }

        public override string ToCSV()
        {
            return getDisplayText(",");
        }
    }
}
