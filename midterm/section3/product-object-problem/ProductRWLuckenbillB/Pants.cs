namespace ProductRWLuckenbillB
{
    class Pants : Apparel
    {
        public int Waist;
        public int Inseam;

        public Pants(string type, string id, string desc, double price, int qty, string material, string color, string manufacturer, int waist, int inseam)
            : base(type, id, desc, price, qty, material, color, manufacturer)
        {
            Waist = waist;
            Inseam = inseam;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{Waist}{separator}{Inseam}";
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
