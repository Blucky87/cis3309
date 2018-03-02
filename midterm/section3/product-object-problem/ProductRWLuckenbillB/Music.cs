namespace ProductRWLuckenbillB
{
    class Music : Entertainment
    {
        public string Genre { get; set; }
        public string Artist { get; set; }
        public string Label { get; set; }

        public Music(string type, string id, string desc, double price, int qty, string rDate, int size, int numDisks, string typeDisk, string rTime, string genre, string artist, string label)
            : base(type, id, desc, price, qty, rDate, size, numDisks, typeDisk, rTime)
        {
            Genre = genre;
            Artist = artist;
            Label = label;
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{Genre}{separator}{Artist}{separator}{Label}";
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
