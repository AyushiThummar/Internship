using Microsoft.EntityFrameworkCore;

namespace StudentInfoDemo.Models
{
    public class StudentInfoDbContext : DbContext
    {
        public StudentInfoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
