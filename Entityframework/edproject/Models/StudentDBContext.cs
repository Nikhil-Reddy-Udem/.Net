using Microsoft.EntityFrameworkCore;

namespace edproject.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
