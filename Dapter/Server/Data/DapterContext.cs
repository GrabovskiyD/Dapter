using Dapter.Shared.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dapter.Shared
{
    public class DapterContext : DbContext
    {
        public DapterContext(DbContextOptions<DapterContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Name = "Властелин колец. Братство Кольца.",
                    Author = "Дж. Р. Р. Толкин",
                    Description = "Величайшее из когда-либо созданных произведений"
                });
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Song> Songs { get; set; } 

    }
}
