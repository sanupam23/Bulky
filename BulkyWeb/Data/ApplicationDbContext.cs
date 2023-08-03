using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
                
        }
        public   DbSet<Category>Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sanupam1", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Sanupam", DisplayOrder = 4 },
                new Category { Id = 9, Name = "Sanupam", DisplayOrder = 7 }
                );
        }
                        
    }
}
