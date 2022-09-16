using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options):base(options)
        {

        }

        public DbSet<Student> Student { set; get; }

        public DbSet<Gender> Gender { set; get; }

        public DbSet<Address> Address { set; get; }

    }
}
