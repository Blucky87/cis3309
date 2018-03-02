namespace ProductRWLuckenbillB
{
    class Product
    {
        public string ID;
        public string Desc;
        public double Price;
        public int Qty;
        public string Type;

        public Product()
        {

        }

        public Product(string type, string id, string desc, double price, int qty)
        {
            ID = id;
            Desc = desc;
            Price = price;
            Qty = qty;
            Type = type;
        }

        public virtual string getDisplayText(string separator)
        {
            return $"{Type}{separator}{ID}{separator}{Desc}{separator}{Price}{separator}{Qty}";
        }

        public override string ToString()
        {
            return getDisplayText("\n");
        }

        public virtual string ToCSV()
        {
            return getDisplayText(",");
        }
    }
}
