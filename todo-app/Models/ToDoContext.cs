using Microsoft.EntityFrameworkCore;

namespace todo_app.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
    }
}
