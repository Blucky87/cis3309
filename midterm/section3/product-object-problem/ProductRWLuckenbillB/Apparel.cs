namespace ProductRWLuckenbillB
{
    class Apparel : Product
    {
        public string Material;
        public string Color;
        public string Manufacturer;

        public Apparel(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer)
            : base(type, id, desc, price, qty)
        {
            Material = material;
            Color = color;
            Manufacturer = manufacturer;
        }

        public override string getDisplayText(string separator)
        {
            string baseString = base.getDisplayText(separator);

            return $"{baseString}{separator}{Material}{separator}{Color}{separator}{Manufacturer}";
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
