// <auto-generated />
using System;
using CaiOttParking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaiOttParking.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20221005122446_firstMig")]
    partial class firstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("longtext");

                    b.HasKey("orderId");

                    b.ToTable("tblOrder");
                });

            modelBuilder.Entity("CaiOttParking.Models.Vehicle", b =>
                {
                    b.Property<string>("vehicleId")
                        .HasColumnType("varchar(255)");

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

                    b.ToTable("tblVehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
