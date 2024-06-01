using Microsoft.EntityFrameworkCore;
using TestApi.DAL.Entity;

namespace TestApi.DAL
{
    public class MyContext:DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        //private readonly string _connectionString;
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
    }
}
