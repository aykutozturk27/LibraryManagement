using LibraryManagement.Core.Utilities.Configuration;
using LibraryManagement.DataAccess.Concrete.EntityFramework.Mappings;
using LibraryManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.DataAccess.Concrete.EntityFramework.Contexts
{
    public class LibraryManagementContext : DbContext
    {
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CoreConfig.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonalMap());
            modelBuilder.ApplyConfiguration(new BookMap());
        }
    }
}
