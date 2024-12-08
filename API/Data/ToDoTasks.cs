using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ToDoTasksContext : DbContext
    {
        public ToDoTasksContext(DbContextOptions<ToDoTasksContext> options) : base(options)
        {
            
        }
    }
}
