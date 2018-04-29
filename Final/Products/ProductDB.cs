using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Products
{
    public class ProductDB
    {
        public int DeleteProduct(string id)
        {
            int count = 0;
            OleDbConnection connection = GetConnection();
            string sql = "DELETE from Products WHERE ID = @id";
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                count = -1;
            }
            finally
            {
                connection.Close();
            }

            return count;
        }

        public ProductList GetAllProducts()
        {
            ProductList productList = new ProductList();
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Products";
            OleDbCommand comm = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ID = reader["ID"].ToString();
                    product.ID = reader["Description"].ToString();
                    product.Price = Double.Parse(reader["Price"].ToString());
                    product.Quantity = Int32.Parse(reader["Quantity"].ToString());

                    productList.Add(product);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }


            return productList;
        }

        OleDbConnection GetConnection()
        {
            var connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\admin\\Downloads\\Products\\Products\\Products\\ProductsDB.accdb";
            var connection = new OleDbConnection(connectionString);
            return connection;
        }

        public Product GetProduct(string id)
        {
            OleDbConnection connection = GetConnection();
            string sql = "SELECT * FROM Products WHERE ID = @id";
            OleDbCommand comm = new OleDbCommand(sql, connection);
            comm.Parameters.AddWithValue("@id", id);
            Product product = null;
            try
            {
                connection.Open();
                OleDbDataReader reader = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    product = new Product();
                    
                    product.ID = reader["ID"].ToString();
                    product.Description = reader["Description"].ToString();
                    product.Price = Double.Parse(reader["Price"].ToString());
                    product.Quantity = Int32.Parse(reader["Quantity"].ToString());
                }
                 reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                
            }

            return product;
        }

        public int InsertProduct(Product product)
        {
            int count = 0;

            OleDbConnection connection = GetConnection();
            string sql = "INSERT INTO Products " +
                         "(ID, Description, Price, Quantity) " +
                         "VALUES (@id, @description, @price, @quantity)";
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.Parameters.AddWithValue("@id", product.ID);
            command.Parameters.AddWithValue("@description", product.Description);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@quantity", product.Quantity);

            try
            {
                connection.Open();
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                count = 0;
            }
            finally
            {
                connection.Close();
            }

            return count;
        }

    }
}