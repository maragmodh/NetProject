using Microsoft.EntityFrameworkCore;
using MaragWeb.Models;

namespace MaragWeb.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {


        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
