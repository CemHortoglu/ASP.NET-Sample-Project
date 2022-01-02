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
    public class UserOperationClimesMap : IEntityTypeConfiguration<UserOperationClimes>
    {
        public void Configure(EntityTypeBuilder<UserOperationClimes> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.HasOne<OperationClime>(a => a.OperationClime).WithMany().HasForeignKey(a => a.OperationClimeId);
            builder.HasOne<User>(a => a.User).WithMany().HasForeignKey(a => a.UserId);
            builder.ToTable("UserOperationClimes");
            builder.HasData(new UserOperationClimes()
            {
                Id = 1,
                UserId = 1,
                OperationClimeId = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            },
            new UserOperationClimes()
            {
                Id = 2,
                UserId = 2,
                OperationClimeId = 1,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            },
            new UserOperationClimes()
            {
                Id = 3,
                UserId = 3,
                OperationClimeId = 2,
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            }
          
     );
        }
    }
}
