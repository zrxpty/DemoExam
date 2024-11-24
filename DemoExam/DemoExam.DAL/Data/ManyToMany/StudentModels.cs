using DemoExam.WinForm.Data.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.WinForm.Data.ManyToMany
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }

    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }

    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        // Дополнительные поля
        public DateTime EnrollmentDate { get; set; }
    }
}

public static partial class ExtendModels
{
    public static ModelBuilder StudentConfigure(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

        modelBuilder.Entity<StudentCourse>()
            .HasOne(sc => sc.Student)
            .WithMany(s => s.StudentCourses)
            .HasForeignKey(sc => sc.StudentId);

        modelBuilder.Entity<StudentCourse>()
            .HasOne(sc => sc.Course)
            .WithMany(c => c.StudentCourses)
            .HasForeignKey(sc => sc.CourseId);

        return modelBuilder;
    }
}
