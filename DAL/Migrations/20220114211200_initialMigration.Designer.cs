﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220114211200_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartmentsProducts", b =>
                {
                    b.Property<int>("DepartmentsDepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("productsArticleNumber")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsDepartmentId", "productsArticleNumber");

                    b.HasIndex("productsArticleNumber");

                    b.ToTable("DepartmentsProducts");

                    b.HasData(
                        new
                        {
                            DepartmentsDepartmentId = 1,
                            productsArticleNumber = 1
                        },
                        new
                        {
                            DepartmentsDepartmentId = 1,
                            productsArticleNumber = 2
                        },
                        new
                        {
                            DepartmentsDepartmentId = 1,
                            productsArticleNumber = 3
                        },
                        new
                        {
                            DepartmentsDepartmentId = 1,
                            productsArticleNumber = 9
                        },
                        new
                        {
                            DepartmentsDepartmentId = 2,
                            productsArticleNumber = 6
                        },
                        new
                        {
                            DepartmentsDepartmentId = 2,
                            productsArticleNumber = 3
                        },
                        new
                        {
                            DepartmentsDepartmentId = 3,
                            productsArticleNumber = 7
                        },
                        new
                        {
                            DepartmentsDepartmentId = 3,
                            productsArticleNumber = 1
                        },
                        new
                        {
                            DepartmentsDepartmentId = 4,
                            productsArticleNumber = 4
                        },
                        new
                        {
                            DepartmentsDepartmentId = 4,
                            productsArticleNumber = 5
                        },
                        new
                        {
                            DepartmentsDepartmentId = 4,
                            productsArticleNumber = 8
                        },
                        new
                        {
                            DepartmentsDepartmentId = 5,
                            productsArticleNumber = 6
                        },
                        new
                        {
                            DepartmentsDepartmentId = 5,
                            productsArticleNumber = 7
                        },
                        new
                        {
                            DepartmentsDepartmentId = 5,
                            productsArticleNumber = 9
                        },
                        new
                        {
                            DepartmentsDepartmentId = 6,
                            productsArticleNumber = 6
                        },
                        new
                        {
                            DepartmentsDepartmentId = 6,
                            productsArticleNumber = 3
                        },
                        new
                        {
                            DepartmentsDepartmentId = 6,
                            productsArticleNumber = 2
                        },
                        new
                        {
                            DepartmentsDepartmentId = 6,
                            productsArticleNumber = 5
                        });
                });

            modelBuilder.Entity("Store.Models.Campaigns", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CampaignName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("CampaignRate")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Campaigns");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CampaignName = "Alv-Veckan",
                            CampaignRate = 0.29999999999999999
                        },
                        new
                        {
                            ID = 2,
                            CampaignName = "Rea-Turn Of The King",
                            CampaignRate = 0.59999999999999998
                        },
                        new
                        {
                            ID = 3,
                            CampaignName = "Princess Birthday",
                            CampaignRate = 0.14999999999999999
                        });
                });

            modelBuilder.Entity("Store.Models.ContentLists", b =>
                {
                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("ArticleNumber")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ContentId", "ArticleNumber");

                    b.HasIndex("ArticleNumber");

                    b.ToTable("ContentLists");

                    b.HasData(
                        new
                        {
                            ContentId = 1,
                            ArticleNumber = 1,
                            Content = "Flower"
                        },
                        new
                        {
                            ContentId = 2,
                            ArticleNumber = 1,
                            Content = "Fire"
                        },
                        new
                        {
                            ContentId = 3,
                            ArticleNumber = 2,
                            Content = "Pork"
                        },
                        new
                        {
                            ContentId = 4,
                            ArticleNumber = 3,
                            Content = "Flour"
                        },
                        new
                        {
                            ContentId = 5,
                            ArticleNumber = 3,
                            Content = "Elven Magic"
                        });
                });

            modelBuilder.Entity("Store.Models.Departments", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("StaffId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Name = "Mejeri",
                            StaffId = 3
                        },
                        new
                        {
                            DepartmentId = 2,
                            Name = "Frukt",
                            StaffId = 1
                        },
                        new
                        {
                            DepartmentId = 3,
                            Name = "Dryck",
                            StaffId = 3
                        },
                        new
                        {
                            DepartmentId = 4,
                            Name = "Skafferi",
                            StaffId = 2
                        },
                        new
                        {
                            DepartmentId = 5,
                            Name = "Bröd",
                            StaffId = 4
                        },
                        new
                        {
                            DepartmentId = 6,
                            Name = "Köttdisken",
                            StaffId = 4
                        });
                });

            modelBuilder.Entity("Store.Models.Emails", b =>
                {
                    b.Property<int>("EmailId")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("EmailId", "StaffId");

                    b.HasIndex("StaffId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            EmailId = 1,
                            StaffId = 1,
                            Email = "deathToDragons@water.com"
                        },
                        new
                        {
                            EmailId = 2,
                            StaffId = 2,
                            Email = "blace4life@hotmales.com"
                        },
                        new
                        {
                            EmailId = 3,
                            StaffId = 3,
                            Email = "took@shire.nu"
                        },
                        new
                        {
                            EmailId = 4,
                            StaffId = 4,
                            Email = "hidden@mail.com"
                        },
                        new
                        {
                            EmailId = 5,
                            StaffId = 5,
                            Email = "mario@mario.com"
                        },
                        new
                        {
                            EmailId = 6,
                            StaffId = 5,
                            Email = "Mario@Nintendo.co.jp"
                        },
                        new
                        {
                            EmailId = 7,
                            StaffId = 6,
                            Email = "harmony@ancient.se"
                        },
                        new
                        {
                            EmailId = 8,
                            StaffId = 7,
                            Email = "'Luigi@Nintendo.co.jp"
                        },
                        new
                        {
                            EmailId = 9,
                            StaffId = 1,
                            Email = "Garbage@mail.com"
                        });
                });

            modelBuilder.Entity("Store.Models.Products", b =>
                {
                    b.Property<int>("ArticleNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleNumber"), 1L, 1);

                    b.Property<int?>("CampaignsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inventory")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("ArticleNumber");

                    b.HasIndex("CampaignsID");

                    b.HasIndex("StaffId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ArticleNumber = 1,
                            CampaignsID = 1,
                            ExpDate = new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4873),
                            Name = "Fire Flower",
                            Price = 200,
                            StaffId = 3,
                            stock = 17
                        },
                        new
                        {
                            ArticleNumber = 2,
                            CampaignsID = 2,
                            ExpDate = new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4902),
                            Name = "Salted Pork",
                            Price = 67,
                            StaffId = 1,
                            stock = 3
                        },
                        new
                        {
                            ArticleNumber = 3,
                            ExpDate = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4906),
                            Name = "Lembas Bread",
                            Price = 13,
                            StaffId = 2,
                            stock = 2
                        },
                        new
                        {
                            ArticleNumber = 4,
                            CampaignsID = 3,
                            ExpDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mushrooms From The Shire",
                            Price = 89,
                            StaffId = 5,
                            stock = 89
                        },
                        new
                        {
                            ArticleNumber = 5,
                            CampaignsID = 1,
                            ExpDate = new DateTime(2022, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4913),
                            Name = "Beorn’s Honey Cake",
                            Price = 120,
                            StaffId = 6,
                            stock = 20
                        },
                        new
                        {
                            ArticleNumber = 6,
                            CampaignsID = 2,
                            ExpDate = new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4916),
                            Name = "Red Shell",
                            Price = 67,
                            StaffId = 1,
                            stock = 3
                        },
                        new
                        {
                            ArticleNumber = 7,
                            CampaignsID = 3,
                            ExpDate = new DateTime(2050, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ent-Draught",
                            Price = 44,
                            StaffId = 6,
                            stock = 88
                        },
                        new
                        {
                            ArticleNumber = 8,
                            ExpDate = new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4923),
                            Name = "Green Shell",
                            Price = 7,
                            StaffId = 4,
                            stock = 0
                        },
                        new
                        {
                            ArticleNumber = 9,
                            ExpDate = new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inventory = new DateTime(2022, 1, 14, 22, 12, 0, 394, DateTimeKind.Local).AddTicks(4926),
                            Name = "Bannana",
                            Price = 15,
                            StaffId = 2,
                            stock = 67
                        });
                });

            modelBuilder.Entity("Store.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("MentorEndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MentorStaffId")
                        .HasColumnType("int");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("StaffId");

                    b.HasIndex("MentorStaffId");

                    b.HasIndex("PersonalNumber")
                        .IsUnique();

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            FirstName = "the Bowman",
                            LastName = "Bard",
                            MentorEndTime = new DateTime(2034, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MentorStaffId = 2,
                            PersonalNumber = "199101025050",
                            PhoneNumber = "030123123"
                        },
                        new
                        {
                            StaffId = 2,
                            FirstName = "Brandybuck",
                            LastName = "Merry",
                            MentorEndTime = new DateTime(2022, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MentorStaffId = 5,
                            PersonalNumber = "199903111250",
                            PhoneNumber = "070420404"
                        },
                        new
                        {
                            StaffId = 3,
                            FirstName = "Took",
                            LastName = "Peregrin",
                            MentorEndTime = new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MentorStaffId = 6,
                            PersonalNumber = "199001025050",
                            PhoneNumber = "030123123"
                        },
                        new
                        {
                            StaffId = 4,
                            FirstName = "Doom",
                            LastName = "Guy",
                            PersonalNumber = "19890111250",
                            PhoneNumber = "070420404"
                        },
                        new
                        {
                            StaffId = 5,
                            FirstName = "Mario",
                            LastName = "Mario",
                            PersonalNumber = "198303111750",
                            PhoneNumber = "070920404"
                        },
                        new
                        {
                            StaffId = 6,
                            FirstName = "Fox",
                            LastName = "Mcload",
                            PersonalNumber = "198903111250",
                            PhoneNumber = "070420484"
                        },
                        new
                        {
                            StaffId = 7,
                            FirstName = "Khazad",
                            LastName = "dûm",
                            PersonalNumber = "191201023033",
                            PhoneNumber = "+12 10111567"
                        });
                });

            modelBuilder.Entity("DepartmentsProducts", b =>
                {
                    b.HasOne("Store.Models.Departments", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Models.Products", null)
                        .WithMany()
                        .HasForeignKey("productsArticleNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Store.Models.ContentLists", b =>
                {
                    b.HasOne("Store.Models.Products", "Product")
                        .WithMany("Contents")
                        .HasForeignKey("ArticleNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store.Models.Departments", b =>
                {
                    b.HasOne("Store.Models.Staff", "Owner")
                        .WithMany("Departments")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Store.Models.Emails", b =>
                {
                    b.HasOne("Store.Models.Staff", "Staff")
                        .WithMany("Emails")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Store.Models.Products", b =>
                {
                    b.HasOne("Store.Models.Campaigns", "Campaigns")
                        .WithMany("Products")
                        .HasForeignKey("CampaignsID");

                    b.HasOne("Store.Models.Staff", "StaffInventory")
                        .WithMany("Inventory")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Campaigns");

                    b.Navigation("StaffInventory");
                });

            modelBuilder.Entity("Store.Models.Staff", b =>
                {
                    b.HasOne("Store.Models.Staff", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorStaffId");

                    b.Navigation("Mentor");
                });

            modelBuilder.Entity("Store.Models.Campaigns", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Store.Models.Products", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("Store.Models.Staff", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Emails");

                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
