// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Paradox.Data.Concrete.EntityFramework.Contexts;

namespace Paradox.Data.Migrations
{
    [DbContext(typeof(ParadoxContext))]
    partial class ParadoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Paradox.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeoTitel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(360)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7241),
                            Description = "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.",
                            IsActive = true,
                            IsDeleted = false,
                            Keyword = "Groceries Groceries",
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7251),
                            SeoTitel = "Groceries",
                            Title = "Groceries"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7779),
                            Description = "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.",
                            IsActive = true,
                            IsDeleted = false,
                            Keyword = "HEALTHY EATING",
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7780),
                            SeoTitel = "HEALTHY EATING",
                            Title = "HEALTHY EATING"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7785),
                            Description = "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.",
                            IsActive = true,
                            IsDeleted = false,
                            Keyword = "RECIPES",
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7786),
                            SeoTitel = "RECIPES",
                            Title = "RECIPES"
                        });
                });

            modelBuilder.Entity("Paradox.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommentCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeoTitel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(360)
                        .HasColumnType("TEXT");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 0,
                            Content = "An MD5 hash is created by taking a string of an any length and encoding it into a 128-bit fingerprint. Encoding the same string using the MD5 algorithm will always result in the same 128-bit hash output. MD5 hashes are commonly used with smaller strings when storing passwords, credit card numbers or other sensitive data in databases such as the popular MySQL. This tool provides a quick and easy way to encode an MD5 hash from a simple string of up to 256 characters in length. MD5 hashes are also used to ensure the data integrity of files. Because the MD5 hash algorithm always produces the same output for the same given input, users can compare a hash of the source file with a newly created hash of the destination file to check that it is intact and unmodified. An MD5 hash is NOT encryption. It is simply a fingerprint of the given input. However, it is a one-way transaction and as such it is almost impossible to reverse engineer an MD5 hash to retrieve the original string.",
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 698, DateTimeKind.Local).AddTicks(4435),
                            Date = new DateTime(2022, 1, 2, 15, 21, 32, 698, DateTimeKind.Local).AddTicks(6101),
                            Description = "32-Character Hardwired LCD Keypad with built-in transceiver",
                            IsActive = true,
                            IsDeleted = false,
                            Keyword = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 698, DateTimeKind.Local).AddTicks(4720),
                            SeoTitel = "InitialCreate",
                            Thumbnail = "Default.jpg",
                            Title = "32-Character Hardwired LCD Keypad with built-in transceiver",
                            ViewsCount = 0
                        });
                });

            modelBuilder.Entity("Paradox.Shared.Entities.Concrete.OperationClime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(360)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OperationClimes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4041),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4046),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4051),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4052),
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Paradox.Shared.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(360)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1364),
                            Email = "cemhortoglu@gmail.com",
                            FullName = "Cem Hortoglu",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1370),
                            Password = new byte[] { 50, 49, 50, 51, 50, 102, 50, 57, 55, 97, 53, 55, 97, 53, 97, 55, 52, 51, 56, 57, 52, 97, 48, 101, 52, 97, 56, 48, 49, 102, 99, 51 }
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1381),
                            Email = "Admin@Admin.com",
                            FullName = "Admin",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1382),
                            Password = new byte[] { 50, 49, 50, 51, 50, 102, 50, 57, 55, 97, 53, 55, 97, 53, 97, 55, 52, 51, 56, 57, 52, 97, 48, 101, 52, 97, 56, 48, 49, 102, 99, 51 }
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1519),
                            Email = "user@user.com",
                            FullName = "User",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1520),
                            Password = new byte[] { 50, 49, 50, 51, 50, 102, 50, 57, 55, 97, 53, 55, 97, 53, 97, 55, 52, 51, 56, 57, 52, 97, 48, 101, 52, 97, 56, 48, 49, 102, 99, 51 }
                        });
                });

            modelBuilder.Entity("Paradox.Shared.Entities.Concrete.UserOperationClimes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("OperationClimeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OperationClimeId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OperationClimeId");

                    b.HasIndex("OperationClimeId1")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClimes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5155),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5160),
                            OperationClimeId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5166),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5167),
                            OperationClimeId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5171),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5172),
                            OperationClimeId = 2,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Paradox.Entities.Concrete.Product", b =>
                {
                    b.HasOne("Paradox.Entities.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Paradox.Shared.Entities.Concrete.UserOperationClimes", b =>
                {
                    b.HasOne("Paradox.Shared.Entities.Concrete.OperationClime", "OperationClime")
                        .WithMany()
                        .HasForeignKey("OperationClimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Paradox.Shared.Entities.Concrete.OperationClime", null)
                        .WithOne("UserOperationClime")
                        .HasForeignKey("Paradox.Shared.Entities.Concrete.UserOperationClimes", "OperationClimeId1");

                    b.HasOne("Paradox.Shared.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClime");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Paradox.Shared.Entities.Concrete.OperationClime", b =>
                {
                    b.Navigation("UserOperationClime");
                });
#pragma warning restore 612, 618
        }
    }
}
