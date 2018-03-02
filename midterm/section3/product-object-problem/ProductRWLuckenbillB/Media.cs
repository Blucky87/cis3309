using System;

namespace ProductRWLuckenbillB
{
    class Media : Product
    {
        private DateTime releaseDate;

        public Media(string type, string id, string desc, double price, int qty, string date)
            : base(type, id, desc, price, qty)
        {
            ReleaseDate = date;
        }

        public string ReleaseDate
        {
            get => releaseDate.ToShortDateString();
            set
            {
                bool isValid = DateTime.TryParse(value, out releaseDate);
                if (!isValid) throw new Exception();
            } 
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{ReleaseDate}";
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
