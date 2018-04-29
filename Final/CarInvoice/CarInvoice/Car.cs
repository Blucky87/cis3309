namespace CarInvoice
{
    public class Car
    {
        private Model model;
        private Package package;
        private Color color;
        private Interior interior;
        
        public Model Model
        {
            get { return model; }
            set { model = value; }
        }

        public Package Package
        {
            get { return package; }
            set { package = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public Interior Interior
        {
            get { return interior; }
            set { interior = value; }
        }

        public int ID;


        public Car(Model model, Package package, Color color, Interior interior, int id)
        {
            Model = model;
            Package = package;
            Color = color;
            Interior = interior;
            ID = id;
        }

        public Car()
        {
            Model = new Model();
            Package = new Package();
            Color = new Color();
            Interior = new Interior();
            ID = 0;
        }
    }
}