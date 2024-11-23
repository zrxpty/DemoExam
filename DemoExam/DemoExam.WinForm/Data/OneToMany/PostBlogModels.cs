using DemoExam.WinForm.Data.ManyToMany;
using DemoExam.WinForm.Data.OneToMany;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.WinForm.Data.OneToMany
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Связь "один ко многим"
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }


    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // Внешний ключ
        public int BlogId { get; set; }

        // Связь с блогом
        public Blog Blog { get; set; }
    }
}

public static partial class ExtendModels
{
    public static ModelBuilder BlogConfigure(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .HasOne(p => p.Blog) 
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BlogId);

        return modelBuilder;
    }
}
