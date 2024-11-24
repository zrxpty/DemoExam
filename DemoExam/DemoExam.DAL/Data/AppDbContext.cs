using DemoExam.WinForm.Data.ManyToMany;
using DemoExam.WinForm.Data.Models;
using DemoExam.WinForm.Data.OneToMany;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.WinForm.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; } = null!;

        #region privates
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


        #endregion

        public AppDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.StudentConfigure();
            modelBuilder.BlogConfigure();
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-VDRG71H\\ZRXPTY;Database=DemoExam1123123123;Integrated Security=True;TrustServerCertificate=True;");

    }
}
