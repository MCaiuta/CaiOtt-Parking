﻿// <auto-generated />
using System;
using CaiOttParking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaiOttParking.Migrations
{
    [DbContext(typeof(_DbContext))]
    partial class _DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CaiOttParking.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("creationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("customerId");

                    b.ToTable("tblCustomer");
                });

            modelBuilder.Entity("CaiOttParking.Models.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("hourEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("hourStart")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("sameDay")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<string>("vehicleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("orderId");

                    b.HasIndex("customerId");

                    b.HasIndex("vehicleId");

                    b.ToTable("tblOrder");
                });

            modelBuilder.Entity("CaiOttParking.Models.Vehicle", b =>
                {
                    b.Property<string>("vehicleId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("vehicleId");

                    b.HasIndex("customerId");

                    b.ToTable("tblVehicle");
                });

            modelBuilder.Entity("CaiOttParking.Models.Car", b =>
                {
                    b.HasBaseType("CaiOttParking.Models.Vehicle");

                    b.Property<int>("doorQuantity")
                        .HasColumnType("int");

                    b.ToTable("tblCar");
                });

            modelBuilder.Entity("CaiOttParking.Models.Motorcycle", b =>
                {
                    b.HasBaseType("CaiOttParking.Models.Vehicle");

                    b.Property<int>("engineCylinder")
                        .HasColumnType("int");

                    b.ToTable("tblMotorCycle");
                });

            modelBuilder.Entity("CaiOttParking.Models.Order", b =>
                {
                    b.HasOne("CaiOttParking.Models.Customer", null)
                        .WithMany("orders")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaiOttParking.Models.Vehicle", null)
                        .WithMany("orders")
                        .HasForeignKey("vehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaiOttParking.Models.Vehicle", b =>
                {
                    b.HasOne("CaiOttParking.Models.Customer", null)
                        .WithMany("vehicles")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaiOttParking.Models.Car", b =>
                {
                    b.HasOne("CaiOttParking.Models.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("CaiOttParking.Models.Car", "vehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaiOttParking.Models.Motorcycle", b =>
                {
                    b.HasOne("CaiOttParking.Models.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("CaiOttParking.Models.Motorcycle", "vehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaiOttParking.Models.Customer", b =>
                {
                    b.Navigation("orders");

                    b.Navigation("vehicles");
                });

            modelBuilder.Entity("CaiOttParking.Models.Vehicle", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
