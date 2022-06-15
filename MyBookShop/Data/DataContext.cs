using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBookShop.Models.Entities;

namespace MyBookShop.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
    : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>().ToTable("users");

/*            modelBuilder.Entity<OrderItem>().HasOne<Book>(b => b.Book).WithOne<Category>(C => C.BookId);*/

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "New Arrival" },
                new Category { CategoryId = 2, Name = "Best Choice" }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, CategoryId = 1, ISBN = "9780451495204", Price = 28.99M, Title = "Mercury Pictures Presents", Created = DateTime.Now, Picture = "https://pub.booklistonline.com/Content/Images/userupload/7/77/771/771d742ab4ee40098075ce28fb7d3084.jpg" },
                new Book { BookId = 2, CategoryId = 1, ISBN = "9780763698225", Price = 24.99M, Title = "The Assassination of Brangwain Spurge", Created = DateTime.Now, Picture = "https://images-na.ssl-images-amazon.com/images/I/519W0nbxbZL.jpg" }
                );

        }

    }
}
