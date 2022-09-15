using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyKitchen.Models;

namespace MyKitchen.DataAccess.Data
{
#pragma warning disable
    public class ApplicationDbContext : IdentityDbContext
    {
        //slas
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts {get; set;}    
    }
}
