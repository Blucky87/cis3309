using System;

namespace ProductRWLuckenbillB
{
    class Entertainment : Disk
    {
        private TimeSpan runTime;

        public Entertainment(string type, string id, string desc, double price, int qty, string rDate, int size, int numDisks, string typeDisk, string rTime)
            : base(type, id, desc, price, qty, rDate, size, numDisks, typeDisk)
        {
            RunTime = rTime;
        }

        public string RunTime
        {
            get => $"{runTime.Hours}:{runTime.Minutes}:{runTime.Seconds}";
            set
            {
                string[] strArray = value.Split(':');
                runTime = new TimeSpan(int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]));
            }
        }

        public override string getDisplayText(string separator)
        {
            string baseClass = base.getDisplayText(separator);

            return $"{baseClass}{separator}{RunTime}";
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
