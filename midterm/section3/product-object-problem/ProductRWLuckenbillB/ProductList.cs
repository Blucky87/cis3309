using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductRWLuckenbillB
{
    class ProductList : List<Product>
    {
        public void Add(string[] data)
        {
            var product = new Product();

            //switch on the first element of the string array passed in to  the method to determine new class
            switch (data[0])
            {
                case "Book":
                    product = 
                        new Book(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5], 
                            int.Parse(data[6]), data[7], data[8]);
                    break;
                case "DressShirt":
                    product =
                        new DressShirt(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5],
                            data[6], data[7], int.Parse(data[8]), int.Parse(data[9]));
                    break;
                case "Movie":
                    product =
                        new Movie(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5],
                            int.Parse(data[6]), int.Parse(data[7]), data[8], data[9], data[10], data[11]);
                    break;
                case "Music":
                    product =
                        new Music(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5],
                            int.Parse(data[6]), int.Parse(data[7]), data[8], data[9], data[10], data[11], data[12]);
                    break;
                case "Pants":
                    product =
                        new Pants(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5],
                            data[6], data[7], int.Parse(data[8]), int.Parse(data[9]));
                    break;
                case "Software":
                    product =
                        new Software(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5],
                            int.Parse(data[6]), int.Parse(data[7]), data[8], data[9]);
                    break;
                case "TShirt":
                    product =
                        new TShirt(data[0], data[1], data[2], double.Parse(data[3]), int.Parse(data[4]), data[5],
                            data[6], data[7], data[8]);
                    break;
                default:
                    product =
                        new Product("Error", "Error", "Error", 0.0, 0);
                    break;
            }
            //add new instance of product to base list object
            Add(product);
        }

        //overrides tostring method for easy output
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            //loop though collection of products and add them to a string builder
            foreach (Product product in this)
            {
                stringBuilder.Append($"{product}");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();
            }
                
            return stringBuilder.ToString();
        }

        //returns a comma separated value string of all products in the collection
        public string ToCSV()
        {
            StringBuilder stringBuilder = new StringBuilder();

            //loop through the collection adding products to the string builder
            foreach (Product product in (List<Product>) this)
            {
                stringBuilder.Append(product.ToCSV());
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }

        //method for reading plaintext file
        public void readFromFile(string fileName)
        {
            //try using a streamreader to read the file
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string readerString = string.Empty;
                
                //keeps reading lines  of the file until it ends
                while ((readerString = streamReader.ReadLine()) != null)
                {
                    //each line of the file is broken up by commas and send to be added to the collection after creating types
                    Add(readerString.Split(','));
                }
            }
        }

        //method for  writng plaintext file
        public void writeToFile(string fileName)
        {
            //try using a streamwriter to  write to filename
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                //loop through collection of  products
                foreach (Product product in (List<Product>)this)
                {
                    //write out the product as csv
                    streamWriter.WriteLine(product.ToCSV());
                }
            }
        }

        //method for writing to bin file
        public void writeToBinary(string fileName)
        {
            //try using binary writer
            using (BinaryWriter binaryWriter =
                new BinaryWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
            {
                //loop through products in collection
                foreach (Product product in this)
                {
                    //write out to file
                    binaryWriter.Write(product.ToCSV());
                }
            }
        }

        //method for reading from bin file
        public void readFromBinary(string fileName)
        {
            //try using binary reader
            using (BinaryReader binaryReader = new BinaryReader(new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                //make sure the end of the file has not been met
                while (binaryReader.PeekChar() != -1)
                {
                    //take string that was read, break it up by commas, send it to be parsed and create type to be added
                    Add(binaryReader.ReadString().Split(','));
                }
            }
        }
    }
}
