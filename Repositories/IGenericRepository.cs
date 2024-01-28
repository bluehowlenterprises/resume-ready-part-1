namespace TodoApplication.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> Add(T entity);
        public Task Update(T entity);
        public Task Remove(T entity);
    }
}
