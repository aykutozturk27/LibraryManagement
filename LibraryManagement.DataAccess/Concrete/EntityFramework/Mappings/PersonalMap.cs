using LibraryManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PersonalMap : IEntityTypeConfiguration<Personal>
    {
        public void Configure(EntityTypeBuilder<Personal> builder)
        {
            builder.ToTable("Personal", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasColumnName("FirstName").HasMaxLength(100);
            builder.Property(x => x.LastName).HasColumnName("LastName").HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(11);
            builder.Property(x => x.IdentityNumber).HasColumnName("IdentityNumber").HasMaxLength(11);

            builder.Property(x => x.IsActive).HasColumnName("IsActive");
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn");
            builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(150);
            builder.Property(x => x.UpdatedOn).HasColumnName("UpdatedOn");
            builder.Property(x => x.UpdatedBy).HasColumnName("UpdatedBy").HasMaxLength(150);

            builder.HasData(
                new Personal
                {
                    Id = 1,
                    FirstName = "Aykut",
                    LastName = "Öztürk",
                    PhoneNumber = "12345678901",
                    IdentityNumber = "12345678901",
                    CreatedBy = "admin"
                },
                new Personal
                {
                    Id = 2,
                    FirstName = "Kamil",
                    LastName = "Ahmet",
                    PhoneNumber = "15789631485",
                    IdentityNumber = "15789631485",
                    CreatedBy = "admin"
                }
            );
        }
    }
}
