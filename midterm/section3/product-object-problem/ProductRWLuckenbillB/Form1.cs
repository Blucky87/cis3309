using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductRWLuckenbillB
{
    public partial class Form1 : Form
    {
        private Product product;
        private ProductList productList;
        private int idx;

        public Form1()
        {
            InitializeComponent();
            //add event to run when form loads
            Load += formLoad;
        }

        //method for setting visable labels and textboxes
        public void drawSet(bool var1, bool var2, bool var3, bool var4, bool var5, bool var6, bool var7, bool var8)
        {
            labelVar1.Visible = textBoxVar1.Visible = var1;
            labelVar2.Visible = textBoxVar2.Visible = var2;
            labelVar3.Visible = textBoxVar3.Visible = var3;
            labelVar4.Visible = textBoxVar4.Visible = var4;
            labelVar5.Visible = textBoxVar5.Visible = var5;
            labelVar6.Visible = textBoxVar6.Visible = var6;
            labelVar7.Visible = textBoxVar7.Visible = var7;
            labelVar8.Visible = textBoxVar8.Visible = var8;
        }

        //method for form load event
        private void formLoad(object sender, EventArgs e)
        {
            productList = new ProductList();
            
            buttonNextProduct.Enabled = false;
            buttonPreviousProduct.Enabled = false;
            buttonWriteSS.Enabled = false;
            buttonWriteBin.Enabled = false;
            drawSet(false, false, false, false, false, false, false, false);
        }

        //Read button clicked
        private void buttonReadSS_Click(object sender, EventArgs e)
        {
            //clear the list of products
            productList.Clear();
            //read csv files
            productList.readFromFile("Products.csv");
            //set index to 0
            idx = 0;
            //display the product
            drawProduct();
            //enable/disable buttons
            buttonNextProduct.Enabled = true;
            buttonPreviousProduct.Enabled = false;
            buttonWriteSS.Enabled = true;
            buttonWriteBin.Enabled = true;
        }

        public void drawProduct()
        {
            //exit  method if index will be out of bounds
            if (idx < 0 || idx >= productList.Count)
                return;
            //load the product at the specified index
            product = productList.ElementAt(idx);
            //set textbox text
            textBoxType.Text = product.Type;
            textBoxId.Text = product.ID;
            textBoxDescription.Text = product.Desc;
            //format string for money
            textBoxPrice.Text = $"{product.Price:C}";
            textBoxQuantity.Text = product.Qty.ToString();

            //switch on the product Type and draw appropriate type
            switch (product.Type)
            {
                case "Book":
                    drawBook();
                    break;
                case "DressShirt":
                    drawDressShirt();
                    break;
                case "Movie":
                    drawMovie();
                    break;
                case "Music":
                    drawMusic();
                    break;
                case "Pants":
                    drawPants();
                    break;
                case "Software":
                    drawSoftware();
                    break;
                case "TShirt":
                    drawTShirt();
                    break;
                default:
                    //show message box if error
                    MessageBox.Show("Unknown Product Type", "Error");
                    break;
            }
        }

        //setup for for book and display information
        private void drawBook()
        {
            Book book = (Book) product;
            drawSet(true, true, true, true, false, false, false, false);
            drawMedia();
            textBoxVar2.Text = book.Author;
            labelVar2.Text = "Author";
            textBoxVar3.Text = book.NumPages.ToString();
            labelVar3.Text = "Pages";
            textBoxVar4.Text = book.Publisher;
            labelVar4.Text = "Publisher";
        }

        //setup form for media and display information
        private void drawMedia()
        {
            Media media = (Media) product;
            textBoxVar1.Text = media.ReleaseDate;
            labelVar1.Text = "Release Date";
        }

        //setup form  for  dressshirt and display information
        private void drawDressShirt()
        {
            DressShirt dressShirt = (DressShirt) product;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            textBoxVar4.Text = dressShirt.Neck.ToString();
            labelVar4.Text = "Neck";
            textBoxVar5.Text = dressShirt.Sleeve.ToString();
            labelVar5.Text = "Sleeve";
        }

        //setup apparel and display information
        private void drawApparel()
        {
            Apparel apparel = (Apparel) product;
            textBoxVar1.Text = apparel.Color;
            labelVar1.Text = "Color";
            textBoxVar2.Text = apparel.Manufacturer;
            labelVar2.Text = "Manufacturer";
            textBoxVar3.Text = apparel.Material;
            labelVar3.Text = "Material";
        }

        //setup movie and display information
        private void drawMovie()
        {
            Movie movie = (Movie) product;
            drawSet(true, true, true, true, true, true, true, false);
            drawEntertainment();
            textBoxVar6.Text = movie.Director;
            labelVar6.Text = "Director";
            textBoxVar7.Text = movie.Producer;
            labelVar7.Text = "Producer";
        }

        //setup entertainment and display information
        private void drawEntertainment()
        {
            Entertainment entertainment = (Entertainment)  product;
            drawDisk();
            textBoxVar5.Text = entertainment.RunTime;
            labelVar5.Text = "Runtime";
        }

        //setup disk and display information
        public void drawDisk()
        {
            Disk disk = (Disk) product;
            drawMedia();
            textBoxVar2.Text = disk.NumDisks.ToString();
            labelVar2.Text = "Number of Disks";
            textBoxVar3.Text = disk.Size.ToString();
            labelVar3.Text = "Data Size";
            textBoxVar4.Text = disk.TypeDisk;
            labelVar4.Text = "Type Disk";
        }

        //setup music and display information
        private void drawMusic()
        {
            Music music = (Music) product;
            drawSet(true, true, true, true, true, true, true, true);
            drawEntertainment();
            textBoxVar6.Text = music.Artist;
            labelVar6.Text = "Artist";
            textBoxVar7.Text = music.Label;
            labelVar7.Text = "Label";
            textBoxVar8.Text = music.Genre;
            labelVar8.Text = "Genre";
        }

        //setup pants  and display information
        private void drawPants()
        {
            Pants pants = (Pants) product;
            drawSet(true, true, true, true, true, false, false, false);
            drawApparel();
            textBoxVar4.Text = pants.Waist.ToString();
            labelVar4.Text = "Waist";
            textBoxVar5.Text = pants.Inseam.ToString();
            labelVar5.Text = "Inseam";
        }

        //setup software and display information
        private void drawSoftware()
        {
            Software software = (Software) product;
            drawSet(true, true, true, true, true, false, false, false);
            drawDisk();
            textBoxVar5.Text = software.TypeSoft;
            labelVar5.Text = "Type Software";
        }

        //setup form for tshirt and display information
        private void drawTShirt()
        {
            TShirt tShirt = (TShirt) product;
            drawSet(true, true, true, true, false, false, false, false);
            drawApparel();
            textBoxVar4.Text = tShirt.Size;
            labelVar4.Text = "Size";
        }

        //event when Next button is clicked
        private void buttonNextProduct_Click(object sender, EventArgs e)
        {
            //change product to the next index
            product = productList.ElementAt<Product>(idx++);
            //display product
            drawProduct();

            //check index to see if Next or previous button should be disabled
            if (idx == productList.Count - 1)
                buttonNextProduct.Enabled = false;
            else
                buttonPreviousProduct.Enabled = true;
        }

        //event when you click previous button
        private void buttonPreviousProduct_Click(object sender, EventArgs e)
        {
            //change product to index
            product = productList.ElementAt<Product>(idx--);
            //display product
            drawProduct();

            //check index to see if Previous or next button should be displayed
            if (idx == 0)
                buttonPreviousProduct.Enabled = false;
            else
                buttonNextProduct.Enabled = true;
        }

        //event when you click the exit button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event when you click read bin
        private void buttonReadBin_Click(object sender, EventArgs e)
        {
            //clear product list
            productList.Clear();
            //read bin file
            productList.readFromBinary("Products.bin");
            //set index to 0
            idx = 0;
            //display product
            drawProduct();
            //setup buttons
            buttonNextProduct.Enabled = true;
            buttonPreviousProduct.Enabled = false;
            buttonWriteSS.Enabled = true;
            buttonWriteBin.Enabled = true;
        }

        private void buttonWriteBin_Click(object sender, EventArgs e)
        {
            //write bin file
            productList.writeToBinary("Output.bin");
        }

        private void buttonWriteSS_Click(object sender, EventArgs e)
        {
            productList.writeToFile("Output.csv");
        }
    }
}
