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
    public class OperationClimeMap : IEntityTypeConfiguration<OperationClime>
    {
        public void Configure(EntityTypeBuilder<OperationClime> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(360);
            builder.Property(a => a.Name).IsRequired();

            builder.ToTable("OperationClimes");
            builder.HasData(new OperationClime()
            {
                Id = 1,
                Name = "Admin",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            },
            new OperationClime()
            {
                Id = 2,
                Name = "User",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            });
        }
    }
}
