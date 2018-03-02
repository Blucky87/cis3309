namespace ProductRWLuckenbillB
{
    class Software : Disk
    {
        public string TypeSoft;

        public Software(string type, string id, string desc, double price, int qty, string rDate, int size, int numDisks, string typeDisk, string typeSoft)
            : base(type, id, desc, price, qty, rDate, size, numDisks, typeDisk)
        {
            TypeSoft = typeSoft;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{TypeSoft}";
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
