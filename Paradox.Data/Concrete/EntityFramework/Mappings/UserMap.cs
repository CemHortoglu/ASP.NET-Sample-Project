using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Paradox.Entities.Concrete;
using Paradox.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.FullName).HasMaxLength(360);
            builder.Property(a => a.FullName).IsRequired();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Email).HasColumnType("NVARCHAR(255)");
            builder.Property(a => a.Password).IsRequired();
            builder.Property(a => a.Password).HasColumnType("NVARCHAR(255)");

            builder.ToTable("Users");
            builder.HasData(new User()
            {
                Id = 1,
                FullName = "Cem Hortoglu",
                Email = "cemhortoglu@gmail.com",
                Password = Encoding.ASCII.GetBytes("21232f297a57a5a743894a0e4a801fc3"),
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,

            },
            new User()
            {
                Id = 2,
                FullName = "Admin",
                Email = "Admin@Admin.com",
                Password = Encoding.ASCII.GetBytes("21232f297a57a5a743894a0e4a801fc3"),
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,

            },
            new User()
            {
                Id = 3,
                FullName = "User",
                Email = "user@user.com",
                Password = Encoding.ASCII.GetBytes("21232f297a57a5a743894a0e4a801fc3"),
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            });

        }
    }
}
