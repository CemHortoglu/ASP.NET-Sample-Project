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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(360);
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(255)");
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.Description).HasColumnType("NVARCHAR(255)");
            builder.Property(a => a.Keyword).IsRequired();
            builder.Property(a => a.Keyword).HasColumnType("NVARCHAR(255)");
            builder.HasOne<Category>(a => a.Category).WithMany().HasForeignKey(a => a.CategoryId);

            builder.ToTable("Products");


            builder.HasData(new Product()
            {
                Id = 1,
                Title = "32-Character Hardwired LCD Keypad with built-in transceiver",
                CategoryId = 1,
                Content = "An MD5 hash is created by taking a string of an any length and encoding it into a 128-bit fingerprint. " +
              "Encoding the same string using the MD5 algorithm will always result in the same 128-bit hash output. MD5 hashes are " +
              "commonly used with smaller strings when storing passwords, credit card numbers or other sensitive data in databases " +
              "such as the popular MySQL. This tool provides a quick and easy way to encode an MD5 hash from a simple string of up to " +
              "256 characters in length. MD5 hashes are also used to ensure the data integrity of files. Because the MD5 hash algorithm " +
              "always produces the same output for the same given input, users can compare a hash of the source file with a newly created" +
              " hash of the destination file to check that it is intact and unmodified. An MD5 hash is NOT encryption. It is simply a fingerprint " +
              "of the given input. However, it is a one-way transaction and as such it is almost impossible to reverse engineer an MD5 hash to " +
              "retrieve the original string.",
                IsActive = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Description = "32-Character Hardwired LCD Keypad with built-in transceiver",
                SeoTitel = "InitialCreate",
                Keyword = "InitialCreate",
                ViewsCount = 0,
                Thumbnail = "Default.jpg",
                Date = DateTime.Now,
                CommentCount = 0
            });
        }
    }
}
