using System.Data.Entity;
using EfDemo.Models.Items;

namespace EfDemo.Classes
{
    public class MyDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public MyDbContext() : base()
        {
            
        }
    }
}
