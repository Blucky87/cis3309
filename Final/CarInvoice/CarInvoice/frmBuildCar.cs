using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInvoice
{
    public partial class frmBuildCar : Form
    {
        private CarDB carDb;
        private ModelList modelList;
        private Customer customer;

        private ColorList colorlist;
        private PackageList packageList;
        private InteriorList interiorList;
        private bool trigger = false;

        public frmBuildCar(Customer customer)
        {
            this.customer = customer;
            carDb = new CarDB();
            InitializeComponent();

            cbxModel.SelectedIndexChanged += cbxModel_SelectedIndexChanged;
            cbxPackage.SelectedIndexChanged += updateText;
            cbxModel.SelectedIndexChanged += updateText;
            cbxColor.SelectedIndexChanged += updateText;
            cbxInterior.SelectedIndexChanged += updateText;
            txtDiscount.Enter += (sender, args) => txtDiscount.Text = String.Empty;

        }

        private void frmBuildCar_Load(object sender, EventArgs e)
        {
            modelList = carDb.SelectModels();

            modelList.ForEach(model => cbxModel.Items.Add(model.Name));
    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int modelId = modelList[cbxModel.SelectedIndex].ID;

            colorlist = carDb.SelectColor(modelId);
            packageList = carDb.SelectPackages(modelId);
            interiorList = carDb.SelectInteriors(modelId);

            cbxColor.Items.Clear();
            cbxPackage.Items.Clear();
            cbxInterior.Items.Clear();

            colorlist.ForEach(color => cbxColor.Items.Add(color.Name));
            packageList.ForEach(package => cbxPackage.Items.Add(package.Name));
            interiorList.ForEach(interior => cbxInterior.Items.Add(interior.Color));

            setDefaults();

            setOutput();

        }

        private void updateText(object sender, EventArgs e)
        {
            setOutput();
        }

        private void setDefaults()
        {
            cbxColor.SelectedIndex = 0;
            cbxPackage.SelectedIndex = 0;
            cbxInterior.SelectedIndex = 0;
        }

        private void setOutput()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (cbxModel.SelectedIndex != -1)
            {
                stringBuilder.AppendLine(outputModel());
                stringBuilder.AppendLine();
            }

            if (cbxPackage.SelectedIndex != -1)
            {
                stringBuilder.AppendLine(outputPackage());
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(outputFeatures());
                stringBuilder.AppendLine();
            }

            if (cbxColor.SelectedIndex != -1)
            {
                stringBuilder.AppendLine(outputColor());
                stringBuilder.AppendLine();
            }

            if (cbxInterior.SelectedIndex != -1)
            {

                stringBuilder.AppendLine(outputInterior());
            }

            rtxtCarInfo.Text = stringBuilder.ToString();
        }

        private string outputModel()
        {
            return $"Model: {modelList[cbxModel.SelectedIndex].Name}";
        }

        private string outputPackage()
        {
            return $"Package: {packageList[cbxPackage.SelectedIndex].Name}";
        }

        private string outputFeatures()
        {
            StringBuilder stringBuilder = new StringBuilder();

            FeatureList featureList = carDb.SelectFeatures(packageList[cbxPackage.SelectedIndex].ID);

            featureList.ForEach(feature => stringBuilder.AppendLine("\t" + feature.Desc));

            return stringBuilder.ToString();
        }

        private string outputColor()
        {
            return $"Color: {colorlist[cbxColor.SelectedIndex].Name}";
        }

        private string outputInterior()
        {
            return $"Interior Color: {interiorList[cbxInterior.SelectedIndex].Color}";
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            double discount, total;
            StringBuilder stringBuilder = new StringBuilder("\n");

            bool validInput = double.TryParse(txtDiscount.Text, out discount);

            if (validInput && cbxPackage.SelectedIndex != -1)
            {
                total = packageList[cbxPackage.SelectedIndex].Price - discount;
                
                stringBuilder.AppendLine($"Discount: {discount:C}");

            }
            else if(cbxPackage.SelectedIndex != -1)
            {
                total = packageList[cbxPackage.SelectedIndex].Price;
                stringBuilder.AppendLine();
                stringBuilder.AppendLine($"Total before fees and taxes: {total:C}");
                stringBuilder.AppendLine("Invalid discount or Package selected. None A");
            }
            
            setOutput();

            rtxtCarInfo.Text += stringBuilder.ToString();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (cbxModel.SelectedIndex == -1)
                return;

            btnCalcTotal_Click(sender, e);

            int invoiceId = carDb.MaxInvoice() + 1;
            int carId = carDb.MaxCar() + 1;
            Model model = modelList[cbxModel.SelectedIndex];
            Package package = packageList[cbxPackage.SelectedIndex];
            Color color = colorlist[cbxColor.SelectedIndex];
            Interior interior = interiorList[cbxInterior.SelectedIndex];

            double discount;

            if (!double.TryParse(txtDiscount.Text, out discount))
            {
                discount = 0.00;
            }

            Car car = new Car(model,package,color,interior, carId);
            carDb.InsertCar(car);

            Invoice invoice = new Invoice(car, customer, discount, invoiceId);
            carDb.InsertInvoice(invoice);
            
        }
    }
}
