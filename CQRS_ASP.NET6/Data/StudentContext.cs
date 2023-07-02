using Microsoft.EntityFrameworkCore;

namespace CQRS_ASP.NETCore6.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
           new Student()
           {
               Id = 1,
               Name = "Murad",
               Surname = "Aliyev",
               Age = 22,
               Degree="Master",
               University="AzTU"
           },
           new Student()
           {
               Id = 2,
               Name = "Elshad",
               Surname = "Babayev",
               Age = 22,
               Degree = "Master",
               University = "AzTU"
           },
           new Student()
           {
               Id = 3,
               Name = "Farid",
               Surname = "Fahiyev",
               Age = 22,
               Degree = "Master",
               University = "ADNSU"
           }
            );
        }
    }
}
