namespace ProductRWLuckenbillB
{
    class Movie : Entertainment
    {
        public string Director;
        public string Producer;

        public Movie(string type, string id, string desc, double price, int qty, string rDate, int size, int numDisks, string typeDisk, string rTime, string director, string producer)
            : base(type, id, desc, price, qty, rDate, size, numDisks, typeDisk, rTime)
        {
            Director = director;
            Producer = producer;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{Director}{separator}{Producer}";
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
