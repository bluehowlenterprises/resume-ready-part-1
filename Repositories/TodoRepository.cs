using TodoApplication.Data;
using TodoApplication.Models;

namespace TodoApplication.Repositories
{
    public class TodoRepository : GenericRepository<Todos>, ITodoRepository
    {
        public TodoRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
