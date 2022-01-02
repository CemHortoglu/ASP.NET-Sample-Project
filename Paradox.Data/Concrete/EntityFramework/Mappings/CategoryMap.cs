using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Paradox.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradox.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(360);
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.Description).HasColumnType("NVARCHAR(255)");
            builder.Property(a => a.Keyword).IsRequired();
            builder.Property(a => a.Keyword).HasColumnType("NVARCHAR(255)");

            builder.ToTable("Categories");

            builder.HasData(new Category()
            {
                Id = 1,
                Title = "Groceries",
                Description = "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Keyword = "Groceries Groceries",
                SeoTitel = "Groceries"
            },
                new Category()
                {
                    Id = 2,
                    Title = "HEALTHY EATING",
                    Description = "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Keyword = "HEALTHY EATING",
                    SeoTitel = "HEALTHY EATING"
                },
                new Category()
                {
                    Id = 3,
                    Title = "RECIPES",
                    Description = "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Keyword = "RECIPES",
                    SeoTitel = "RECIPES"
                });
        }
    }
}
