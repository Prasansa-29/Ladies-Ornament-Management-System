using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FANCY_CLOTHES_MANAGEMENT.Data;
using Fancy.Models.Items;
using System.Reflection.Emit;

namespace FANCY_CLOTHES_MANAGEMENT.Services
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BrandCategory> BrandCategories { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<Wishlist> Wishlist { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var Merchant = new IdentityRole("Merchant");
            Merchant.NormalizedName = "Merchant";

            var Customer = new IdentityRole("Customer");
            Customer.NormalizedName = "Customer";


            builder.Entity<BrandCategory>()
          .HasMany(bc => bc.Products)
          .WithOne(p => p.BrandCategory)
          .HasForeignKey(p => p.BrandCategoryId);  // Foreign key banako 



            builder.Entity<BrandCategory>().Ignore(bc => bc.Products); //This means we ignored that "Unable to determine the relationship represented by navigation 'BrandCategory.Products' of type 'ICollection<Product>'. Either manually configure the relationship, or ignore this property using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'.", this was the error while adding miggration so 


        }
    }
}
   