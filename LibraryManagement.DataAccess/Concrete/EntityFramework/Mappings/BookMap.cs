using LibraryManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.BookName).HasColumnName("Name").HasMaxLength(150);
            builder.Property(x => x.Author).HasColumnName("Author").HasMaxLength(150);
            builder.Property(x => x.ISBN).HasColumnName("ISBN").HasMaxLength(150);
            builder.Property(x => x.ReceivingDate).HasColumnName("ReceivingDate");
            builder.Property(x => x.ReturnDate).HasColumnName("ReturnDate");
            builder.Property(x => x.IsBorrowed).HasColumnName("IsBorrowed");

            builder.Property(x => x.IsActive).HasColumnName("IsActive");
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn");
            builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(150);
            builder.Property(x => x.UpdatedOn).HasColumnName("UpdatedOn");
            builder.Property(x => x.UpdatedBy).HasColumnName("UpdatedBy").HasMaxLength(150);

            builder.HasOne(x => x.Personal).WithMany(x => x.Books).HasForeignKey(x => x.PersonalId);

            builder.HasData(
                new Book
                {
                    Id = 1,
                    BookName = "Sefiller",
                    Author = "Victor Hugo",
                    ISBN = "13345678912",
                    ReceivingDate = DateTime.Now.AddDays(-10),
                    ReturnDate = DateTime.Now.AddDays(1),
                    IsBorrowed = false,
                    PersonalId = 1
                },
                new Book
                {
                    Id = 2,
                    BookName = "Şeker Portakalı",
                    Author = "Jose Mauro De Vasconcelos",
                    ISBN = "13345678912",
                    ReceivingDate = DateTime.Now.AddDays(-10),
                    ReturnDate = DateTime.Now.AddDays(1),
                    IsBorrowed = false,
                    PersonalId = 2
                }
            );
        }
    }
}
