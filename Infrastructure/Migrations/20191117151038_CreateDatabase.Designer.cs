﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191117151038_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Core.Entities.Car", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CarTypeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberPlate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isWifiAvailable")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Core.Entities.CarType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

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
                            Id = "1",
                            Cost = 700000m,
                            Name = "Ford EcoSport",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = "2",
                            Cost = 1500000m,
                            Name = "Ford Everest",
                            Seat = (byte)7
                        },
                        new
                        {
                            Id = "3",
                            Cost = 700000m,
                            Name = "Ford Fiesta",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = "4",
                            Cost = 500000m,
                            Name = "Kia Morning",
                            Seat = (byte)5
                        },
                        new
                        {
                            Id = "5",
                            Cost = 700000m,
                            Name = "Kia Cerato",
                            Seat = (byte)5
                        });
                });

            modelBuilder.Entity("Core.Entities.Car", b =>
                {
                    b.HasOne("Core.Entities.CarType", "CarType")
                        .WithMany("Cars")
                        .HasForeignKey("CarTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}