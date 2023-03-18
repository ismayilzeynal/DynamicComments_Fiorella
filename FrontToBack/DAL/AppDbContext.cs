
using FrontToBack.Models;
using FrontToBack.Models.Demo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options ) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Bio> Bios { get; set; }

        //demo
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImages> BookImages { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<SocialPage> SocialPages { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesProducts> SalesProducts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }





    }
}
