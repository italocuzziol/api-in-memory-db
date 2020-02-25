using Microsoft.EntityFrameworkCore;

namespace MyFirstApi.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
    }
}