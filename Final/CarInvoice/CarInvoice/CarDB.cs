using System;
using System.Data.OleDb;

namespace CarInvoice
{
    public class CarDB
    {
        public OleDbConnection GetConnection()
        {
            string connectionString = GetConnectionString();
            OleDbConnection connection = new OleDbConnection(connectionString);
            return connection;
        }

        public string GetConnectionString()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\repo\\cis3309\\Final\\CarInvoice\\CarInvoice\\CarDB.mdb";

            return connectionString;
        }

        public void InsertCar(Car car)
        {
            OleDbConnection connection = GetConnection();
            string sql = "INSERT INTO Cars " +
                         "(ID, ModelID, ColorID, InteriorID, PackageID) " +
                         "VALUES (@id, @modelId, @colorId, @interiorId, @packageId)";
            OleDbCommand command = new OleDbCommand(sql, connection);

            command.Parameters.AddWithValue("@id", car.ID);
            command.Parameters.AddWithValue("@modelId", car.Model.ID);
            command.Parameters.AddWithValue("@colorId", car.Color.ID);
            command.Parameters.AddWithValue("@interiorId", car.Interior.ID);
            command.Parameters.AddWithValue("@packageId", car.Package.ID);

        }

        public void InsertCustomer(Customer customer)
        {
            OleDbConnection connection = GetConnection();
            string sql = "INSERT INTO Customers " +
                         "(FirstName, LastName, Address, City, State, ZipCode) " +
                         "VALUES (@firstName, @lastName, @address, @city, @state, @zipCode)";
            OleDbCommand command = new OleDbCommand(sql, connection);

//            command.Parameters.AddWithValue("@id", customer.ID);
            command.Parameters.AddWithValue("@firstName", customer.FirstName);
            command.Parameters.AddWithValue("@lastName", customer.LastName);
            command.Parameters.AddWithValue("@address", customer.Address);
            command.Parameters.AddWithValue("@city", customer.City);
            command.Parameters.AddWithValue("@state", customer.State);
            command.Parameters.AddWithValue("@zipCode", customer.ZipCode);

        }

        public void InsertInvoice(Invoice invoice)
        {
            OleDbConnection connection = GetConnection();
            string sql = "INSERT INTO Invoices " +
                         "(CustomerID, CarID, Discount) " +
                         "VALUES (@customerId, @carId, @dicount)";
            OleDbCommand command = new OleDbCommand(sql, connection);

//            command.Parameters.AddWithValue("@id", invoice.ID);
            command.Parameters.AddWithValue("@customerId", invoice.Customer.ID);
            command.Parameters.AddWithValue("@carId", invoice.Car.ID);
            command.Parameters.AddWithValue("@dicount", invoice.Discount);
 
        }

        public int MaxCar()
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT count(*) FROM Cars";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            int max = 0;

            try
            {
                connection.Open();
                
                max = (Int32)comm.ExecuteScalar();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return max;
        }

        public int MaxCustomer()
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT count(*) FROM Customers";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            int max = 0;

            try
            {
                connection.Open();

                max = (Int32)comm.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return max;
        }

        public int MaxInvoice()
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT count(*) FROM Invoices";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            int max = 0;

            try
            {
                connection.Open();

                max = (Int32)comm.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return max;
        }

        public Color GetColor(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Colors WHERE ID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            Color color = null;
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    color = new Color
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Name = reader["Name"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return color;
        }

        public Feature GetFeature(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Features WHERE ID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            Feature feature = null;
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    feature = new Feature
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Desc = reader["Desc"].ToString()
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return feature;
        }

        public ColorList SelectColor(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM ModelColors WHERE ModelID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            ColorList colorList = new ColorList();
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                Color color = null;
                while (reader.Read())
                {
                    int colorId = int.Parse(reader["ColorID"].ToString());
                    color = GetColor(colorId);

                    colorList.Add(color);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return colorList;
        }

        public Customer SelectCustomer(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Customers WHERE ID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            Customer customer = null;
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Address = reader["Address"].ToString(),
                        City = reader["City"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        State = reader["State"].ToString(),
                        ZipCode = reader["ZipCode"].ToString()
                        
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return customer;
        }

        public FeatureList SelectFeatures(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM PackageFeatures WHERE PackageID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            FeatureList featureList = new FeatureList();
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                while(reader.Read())
                {
                    int featureId = int.Parse(reader["FeatureId"].ToString());
                    Feature feature = GetFeature(featureId);
                    
                    featureList.Add(feature);
                }
                
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return featureList;
        }

        public InteriorList SelectInteriors(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Interiors WHERE ID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            InteriorList interiorList = new InteriorList();

            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                Interior interior = null;
                while(reader.Read())
                {
                    interior = new Interior
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Color = reader["Color"].ToString()
                    };

                    interiorList.Add(interior);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return interiorList;
        }

        public ModelList SelectModels(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Models WHERE ID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            ModelList modelList = new ModelList();
            
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                Model model = null;
                while(reader.Read())
                {
                    model = new Model
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Name = reader["Name"].ToString(),
                        Image = reader["Image"].ToString(),
                        Make = reader["Make"].ToString(),
                        Year = int.Parse(reader["Year"].ToString())
                    };

                    modelList.Add(model);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return modelList;
        }

        public PackageList SelectPackages(int id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Packages WHERE ModelID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            PackageList packageList = new PackageList();

            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
                Package package = null;
                while (reader.Read())
                {
                    package = new Package
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString(),
                        ModelID = int.Parse(reader["ModelID"].ToString()),
                        Price = double.Parse(reader["Price"].ToString())
                    };

                    packageList.Add(package);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return packageList;
        }

    }
}