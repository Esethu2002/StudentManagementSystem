using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding data for the Student entity
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, StudentName = "Esethu Mjila", StudentEmail = "esermjila07@gmail.com", StudentPhone = "0604269728" },
                new Student { StudentId = 2, StudentName = "Asive Myeni", StudentEmail = "asivemyeni@gmail.com", StudentPhone = "0736379802" },
                new Student { StudentId = 3, StudentName = "Michael Johnson", StudentEmail = "michael.j@example.com", StudentPhone = "555-111-2222" },
                new Student { StudentId = 4, StudentName = "Emily Davis", StudentEmail = "emily.d@example.com", StudentPhone = "444-222-3333" },
                new Student { StudentId = 5, StudentName = "William Brown", StudentEmail = "william.b@example.com", StudentPhone = "333-999-8888" },
                new Student { StudentId = 6, StudentName = "Jessica Taylor", StudentEmail = "jessica.t@example.com", StudentPhone = "666-777-8888" },
                new Student { StudentId = 7, StudentName = "David Wilson", StudentEmail = "david.w@example.com", StudentPhone = "777-888-9999" },
                new Student { StudentId = 8, StudentName = "Sarah Lee", StudentEmail = "sarah.l@example.com", StudentPhone = "222-333-4444" },
                new Student { StudentId = 9, StudentName = "James White", StudentEmail = "james.w@example.com", StudentPhone = "888-999-0000" },
                new Student { StudentId = 10, StudentName = "Ashley Harris", StudentEmail = "ashley.h@example.com", StudentPhone = "999-000-1111" }
            );

        }
    }
}
