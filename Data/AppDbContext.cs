using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

namespace ToDoList.Data;

public class AppDbContext : DbContext
{
    public DbSet<ToDo> ToDoList { get; set; } 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}