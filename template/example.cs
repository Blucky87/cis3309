public static Customer GetCustomer(int CustomerID)
{
    OleDbConnection conn = MMABooksAcc.GetConnection();
    string sql = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
    OleDbCommand comm = new OleDbCommand(sql, conn);
    comm.Parameters.AddWithValue("@CustomerID", CustomerID);
    Customer c = null;
    try
    {
        conn.Open();
        OleDbDataReader dr = comm.ExecuteReader(System.Data.CommandBehavior.SingleRow);
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

{}
public static int InsertCustomer(Customer c)
{
    OleDbConnection conn = MMABooksAcc.GetConnection();
    string sql = "INSERT Customers " +
        "(Name, Address, City, State, ZipCode) " +
        "VALUES (@Name, @Address, @City, @State, @Zipcode)";
    OleDbCommand comm = new OleDbCommand(sql, conn);
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