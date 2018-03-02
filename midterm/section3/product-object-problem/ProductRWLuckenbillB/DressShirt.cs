namespace ProductRWLuckenbillB
{
    class DressShirt : Apparel
    {
        public int Neck;
        public int Sleeve;

        public DressShirt(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer, int neck, int sleeve)
            : base(type, id, desc, price, qty, material, color, manufacturer)
        {
            Neck = neck;
            Sleeve = sleeve;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{Neck}{separator}{Sleeve}";
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
