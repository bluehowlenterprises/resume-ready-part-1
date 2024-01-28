using Microsoft.EntityFrameworkCore;
using TodoApplication.Data;

namespace TodoApplication.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DataContext DataContext;
        public GenericRepository(DataContext DataContext) => this.DataContext = DataContext;

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.DataContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await this.DataContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            await this.DataContext.Set<T>().AddAsync(entity);
            await this.DataContext.SaveChangesAsync();
            return entity;
        }

        public async Task Update(T entity)
        {
            this.DataContext.Set<T>().Update(entity);
            await this.DataContext.SaveChangesAsync();
        }

        public async Task Remove(T entity)
        {
            this.DataContext.Set<T>().Remove(entity);
            await this.DataContext.SaveChangesAsync();
        }
    }
}
