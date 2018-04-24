    public interface IDatabase<T>
    {
        T Get(int entityId);
        List<T> GetAll();
        bool Update(T entity);
        bool Insert(T entity);
        bool Delete(int entityId);

        DbConnection CreateConnection();
    }