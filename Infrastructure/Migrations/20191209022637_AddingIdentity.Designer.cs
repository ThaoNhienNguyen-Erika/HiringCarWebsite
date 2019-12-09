﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191209022637_AddingIdentity")]
    partial class AddingIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Core.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberPlate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarTypeId = 19,
                            Color = "White",
                            ImgPath = "img_51G_23560",
                            NumberPlate = "51G-23560"
                        },
                        new
                        {
                            Id = 2,
                            CarTypeId = 12,
                            Color = "Silver",
                            ImgPath = "img_51G_69186",
                            NumberPlate = "51G-69186"
                        },
                        new
                        {
                            Id = 3,
                            CarTypeId = 14,
                            Color = "White",
                            ImgPath = "img_51G_74141",
                            NumberPlate = "51G-74141"
                        },
                        new
                        {
                            Id = 4,
                            CarTypeId = 16,
                            Color = "White",
                            ImgPath = "img_51G_65404",
                            NumberPlate = "51G-65404"
                        },
                        new
                        {
                            Id = 5,
                            CarTypeId = 10,
                            Color = "White",
                            ImgPath = "img_94A_19715",
                            NumberPlate = "94A-19715"
                        },
                        new
                        {
                            Id = 6,
                            CarTypeId = 13,
                            Color = "White",
                            ImgPath = "img_51G_22986",
                            NumberPlate = "51G-22986"
                        },
                        new
                        {
                            Id = 7,
                            CarTypeId = 9,
                            Color = "Silver",
                            ImgPath = "img_51G_23186",
                            NumberPlate = "51G-23186"
                        },
                        new
                        {
                            Id = 8,
                            CarTypeId = 15,
                            Color = "White",
                            ImgPath = "img_51G_63428",
                            NumberPlate = "51G-63428"
                        },
                        new
                        {
                            Id = 9,
                            CarTypeId = 18,
                            Color = "White",
                            ImgPath = "img_51G_75835",
                            NumberPlate = "51G-75835"
                        },
                        new
                        {
                            Id = 10,
                            CarTypeId = 10,
                            Color = "White",
                            ImgPath = "img_94A_37715",
                            NumberPlate = "94A-37715"
                        },
                        new
                        {
                            Id = 11,
                            CarTypeId = 13,
                            Color = "White",
                            ImgPath = "img_51G_32986",
                            NumberPlate = "51G-32986"
                        },
                        new
                        {
                            Id = 12,
                            CarTypeId = 21,
                            Color = "White",
                            ImgPath = "img_61A_76150",
                            NumberPlate = "61A-76150"
                        },
                        new
                        {
                            Id = 13,
                            CarTypeId = 11,
                            Color = "Black",
                            ImgPath = "img_51G_37128",
                            NumberPlate = "51G-37128"
                        },
                        new
                        {
                            Id = 14,
                            CarTypeId = 11,
                            Color = "Silver",
                            ImgPath = "img_51G_99604",
                            NumberPlate = "51G-99604"
                        },
                        new
                        {
                            Id = 15,
                            CarTypeId = 13,
                            Color = "White",
                            ImgPath = "img_51F_56476",
                            NumberPlate = "51F-56476"
                        },
                        new
                        {
                            Id = 16,
                            CarTypeId = 13,
                            Color = "Dark Blue",
                            ImgPath = "img_51G_89975",
                            NumberPlate = "51G-89975"
                        },
                        new
                        {
                            Id = 17,
                            CarTypeId = 22,
                            Color = "White",
                            ImgPath = "img_51G_21640",
                            NumberPlate = "51G-21640"
                        },
                        new
                        {
                            Id = 18,
                            CarTypeId = 18,
                            Color = "White",
                            ImgPath = "img_51A_48815",
                            NumberPlate = "51A-48815"
                        },
                        new
                        {
                            Id = 19,
                            CarTypeId = 14,
                            Color = "Red",
                            ImgPath = "img_51G_58430",
                            NumberPlate = "51G-58430"
                        },
                        new
                        {
                            Id = 20,
                            CarTypeId = 6,
                            Color = "White",
                            ImgPath = "img_51G_22488",
                            NumberPlate = "51G-22488"
                        },
                        new
                        {
                            Id = 21,
                            CarTypeId = 5,
                            Color = "White",
                            ImgPath = "img_51F_12136",
                            NumberPlate = "51F-12136"
                        },
                        new
                        {
                            Id = 22,
                            CarTypeId = 2,
                            Color = "Silver",
                            ImgPath = "img_51F_90254",
                            NumberPlate = "51F-90254"
                        },
                        new
                        {
                            Id = 23,
                            CarTypeId = 16,
                            Color = "White",
                            ImgPath = "img_51G_66404",
                            NumberPlate = "51G-66404"
                        },
                        new
                        {
                            Id = 24,
                            CarTypeId = 14,
                            Color = "White",
                            ImgPath = "img_51G_57912",
                            NumberPlate = "51G-57912"
                        },
                        new
                        {
                            Id = 25,
                            CarTypeId = 2,
                            Color = "Black",
                            ImgPath = "img_51H_23163",
                            NumberPlate = "51H-23163"
                        },
                        new
                        {
                            Id = 26,
                            CarTypeId = 4,
                            Color = "Red",
                            ImgPath = "img_51F_56959",
                            NumberPlate = "51F-56959"
                        },
                        new
                        {
                            Id = 27,
                            CarTypeId = 11,
                            Color = "Silver",
                            ImgPath = "img_51G_35204",
                            NumberPlate = "51G-35204"
                        },
                        new
                        {
                            Id = 28,
                            CarTypeId = 5,
                            Color = "White",
                            ImgPath = "img_51G_12592",
                            NumberPlate = "51G-12592"
                        },
                        new
                        {
                            Id = 29,
                            CarTypeId = 18,
                            Color = "White",
                            ImgPath = "img_51G_74963",
                            NumberPlate = "51G-74963"
                        },
                        new
                        {
                            Id = 30,
                            CarTypeId = 12,
                            Color = "White",
                            ImgPath = "img_51G_33591",
                            NumberPlate = "51G-33591"
                        },
                        new
                        {
                            Id = 31,
                            CarTypeId = 15,
                            Color = "White",
                            ImgPath = "img_51G_22542",
                            NumberPlate = "51G-22542"
                        },
                        new
                        {
                            Id = 32,
                            CarTypeId = 17,
                            Color = "White",
                            ImgPath = "img_51G_32014",
                            NumberPlate = "51G-32014"
                        });
                });

            modelBuilder.Entity("Core.Entities.CarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Seat")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CarType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 700000m,
                            Name = "Ford EcoSport",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 2,
                            Cost = 1500000m,
                            Name = "Ford Everest",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 3,
                            Cost = 700000m,
                            Name = "Ford Fiesta",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 4,
                            Cost = 500000m,
                            Name = "Kia Morning",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 5,
                            Cost = 700000m,
                            Name = "Kia Cerato",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 6,
                            Cost = 1100000m,
                            Name = "Kia Sorento",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 7,
                            Cost = 800000m,
                            Name = "Rondo",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 8,
                            Cost = 1600000m,
                            Name = "Sendona",
                            Seat = (byte)8
                        },
                        new
                        {
                            Id = 9,
                            Cost = 100000m,
                            Name = "Camry",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 10,
                            Cost = 1200000m,
                            Name = "Fortuner",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 11,
                            Cost = 700000m,
                            Name = "Innova",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 12,
                            Cost = 900000m,
                            Name = "Toyota Corrola Altis",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 13,
                            Cost = 800000m,
                            Name = "Mazda 3",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 14,
                            Cost = 1200000m,
                            Name = "Mazda CX5",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 15,
                            Cost = 2000000m,
                            Name = "Mescedes CLA",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 16,
                            Cost = 2000000m,
                            Name = "Mescedes C200",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 17,
                            Cost = 2200000m,
                            Name = "Mescedes C250",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 18,
                            Cost = 700000m,
                            Name = "Honda City",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 19,
                            Cost = 800000m,
                            Name = "Honda City TOP",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 20,
                            Cost = 1200000m,
                            Name = "Chevrolet Blazetrailer",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 21,
                            Cost = 600000m,
                            Name = "Vinfast Fadil",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 22,
                            Cost = 900000m,
                            Name = "Huyndai Kona",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 23,
                            Cost = 1400000m,
                            Name = "Peugoet",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = 24,
                            Cost = 1500000m,
                            Name = "Ford Tourneo",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = 25,
                            Cost = 1300000m,
                            Name = "Mazda 6",
                            Seat = (byte)4
                        },
                        new
                        {
                            Id = 26,
                            Cost = 1100000m,
                            Name = "Honda Civic",
                            Seat = (byte)5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Core.Entities.Car", b =>
                {
                    b.HasOne("Core.Entities.CarType", "CarType")
                        .WithMany("Cars")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
