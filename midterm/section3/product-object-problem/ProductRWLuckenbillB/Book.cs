namespace ProductRWLuckenbillB
{
    class Book : Media
    {
        public int NumPages;
        public string Author;
        public string Publisher;

        public Book(string type, string id, string desc, double price, int qty, string date, int numPages, string author, string publisher)
            : base(type, id, desc, price, qty, date)
        {
            NumPages = numPages;
            Author = author;
            Publisher = publisher;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{NumPages}{separator}{Author}{separator}{Publisher}";
        }

        public override string ToString()
        {
            return getDisplayText("\r\n");
        }

        public override string ToCSV()
        {
            return getDisplayText(",");
        }
    }
}
