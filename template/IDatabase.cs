public interface IDatabase<T>
{
    T Get(int entityId);
    List<T> GetAll();
    bool Update(T entity);
    bool Insert(T entity);
    bool Delete(int entityId);

    DbConnection CreateConnection();
}

public static string GetConnectionString()
{
    // Get the conn string from database.txt file in project root directory - for debugging
    string s = File.ReadAllText(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName + @"\databaseAcc.txt");
    return s;
}


public static OleDbConnection GetConnection()
{
    return new OleDbConnection(GetConnectionString());
}

//listbox.Items.Add and selected index changed.