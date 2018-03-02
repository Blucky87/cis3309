namespace ProductRWLuckenbillB
{
    class Disk: Media
    {
        public int Size;
        public int NumDisks;
        public string TypeDisk;

        public Disk(string type, string id, string desc, double price, int qty, string rDate, int size, int numDisks, string typeDisk)
            : base(type, id, desc, price, qty, rDate)
        {
            Size = size;
            NumDisks = numDisks;
            TypeDisk = typeDisk;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{Size}{separator}{NumDisks}{separator}{TypeDisk}";
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
