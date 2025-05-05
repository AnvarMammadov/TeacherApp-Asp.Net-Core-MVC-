using Microsoft.EntityFrameworkCore;

namespace TeacherAp.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI;database=TeachDB;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
