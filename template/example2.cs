public static Customer GetCustomer(int CustomerID)
{
    SqlConnection conn = MMABooks.GetConnection();
    string sql = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
    SqlCommand comm = new SqlCommand(sql, conn);
    comm.Parameters.AddWithValue("@CustomerID", CustomerID);
    Customer c = null;
    try
    {
        conn.Open();
        SqlDataReader dr = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
        if (dr.Read())
        {
            c = new Customer();
            c.CustomerID = Convert.ToInt32(dr["CustomerID"]);
            c.Name = dr["Name"].ToString();
            c.Address = dr["Address"].ToString();
            c.City = dr["City"].ToString();
            c.State = dr["State"].ToString();
            c.ZipCode = dr["ZipCode"].ToString();
        }
        return c;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
    finally
    {
        conn.Close();
    }
    return null;
}


public static int UpdateCustomer(Customer c)
{
    SqlConnection conn = MMABooks.GetConnection();
    string sql = "UPDATE Customers SET " + 
        "Name = @Name, " + 
        "Address = @Address, " +
        "City = @City, " +
        "State = @State, " +
        "ZipCode = @Zipcode " +
        "WHERE CustomerID = @CustomerID";
    SqlCommand comm = new SqlCommand(sql, conn);
    comm.Parameters.AddWithValue("@Name", c.Name);
    comm.Parameters.AddWithValue("@Address", c.Address);
    comm.Parameters.AddWithValue("@City", c.City);
    comm.Parameters.AddWithValue("@State", c.State);
    comm.Parameters.AddWithValue("@ZipCode", c.ZipCode);
    comm.Parameters.AddWithValue("@CustomerID", c.CustomerID);
    int count = 0;
    try
    {
        conn.Open();
        count = comm.ExecuteNonQuery();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
    finally
    {
        conn.Close();
    }
    return count;
}


public static int InsertCustomer(Customer c)
{
    SqlConnection conn = MMABooks.GetConnection();
    string sql = "INSERT Customers " +
        "(Name, Address, City, State, ZipCode) " +
        "VALUES (@Name, @Address, @City, @State, @Zipcode)";
    SqlCommand comm = new SqlCommand(sql, conn);
    comm.Parameters.AddWithValue("@Name", c.Name);
    comm.Parameters.AddWithValue("@Address", c.Address);
    comm.Parameters.AddWithValue("@City", c.City);
    comm.Parameters.AddWithValue("@State", c.State);
    comm.Parameters.AddWithValue("@ZipCode", c.ZipCode);
    int count = 0;
    try
    {
        conn.Open();
        count = comm.ExecuteNonQuery();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
    finally
    {
        conn.Close();
    }
    return count;
}


public static int DeleteCustomer(int CustomerID)
{
    SqlConnection conn = MMABooks.GetConnection();
    string sql = "DELETE FROM Customers WHERE CustomerID = @CustomerID" ;
    SqlCommand comm = new SqlCommand(sql, conn);
    comm.Parameters.AddWithValue("@CustomerID", CustomerID);
    int count = 0;
    try
    {
        conn.Open();
        count = comm.ExecuteNonQuery();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
    finally
    {
        conn.Close();
    }
    return count;
}


public static CustomerList GetAllCustomers()
{
    SqlConnection conn = MMABooks.GetConnection();
    string sql = "SELECT * FROM Customers";
    SqlCommand comm = new SqlCommand(sql, conn);
    CustomerList cl = new CustomerList();
    try
    {
        conn.Open();
        SqlDataReader dr = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
        while (dr.Read())
        {
            Customer c = new Customer();
            c.CustomerID = Convert.ToInt32(dr["CustomerID"]);
            c.Name = dr["Name"].ToString();
            c.Address = dr["Address"].ToString();
            c.City = dr["City"].ToString();
            c.State = dr["State"].ToString();
            c.ZipCode = dr["ZipCode"].ToString();
            cl.Add(c);
        }
        return cl;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
    finally
    {
        conn.Close();
    }
    return null;
}

{}
public static InvoiceList GetInvoices(int customerId)
{
    SqlConnection conn = MMABooks.GetConnection();
    string sql = "SELECT * FROM Invoices WHERE CustomerID = @CustomerID";
    SqlCommand comm = new SqlCommand(sql, conn);
    comm.Parameters.AddWithValue("@CustomerID", customerId);
    InvoiceList il = new InvoiceList();
    try
    {
        conn.Open();
        SqlDataReader dr = comm.ExecuteReader(System.Data.CommandBehavior.SingleResult);
        while (dr.Read())
        {
            Invoice i = new Invoice();
            i.InvoiceID = Convert.ToInt32(dr["InvoiceID"]);
            i.CustomerID = Convert.ToInt32(dr["CustomerID"]);
            i.Date = dr["InvoiceDate"].ToString();
            i.ProductTotal = Convert.ToDouble(dr["ProductTotal"]);
            i.SalesTax = Convert.ToDouble(dr["SalesTax"]);
            i.Shipping = Convert.ToDouble(dr["Shipping"]);
            i.InvoiceTotal = Convert.ToDouble(dr["InvoiceTotal"]);
            il.Add(i);
        }
        return il;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
    finally
    {
        conn.Close();
    }
    return null;
}