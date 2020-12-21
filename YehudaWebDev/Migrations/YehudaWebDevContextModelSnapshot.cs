﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YehudaWebDev.Data;

namespace YehudaWebDev.Migrations
{
    [DbContext(typeof(YehudaWebDevContext))]
    partial class YehudaWebDevContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YehudaWebDev.Models.Airlines", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<string>("AirlineCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirlineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPlanes")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWorkers")
                        .HasColumnType("int");

                    b.Property<int>("YearOfEstablishment")
                        .HasColumnType("int");

                    b.Property<double>("YearlyTravelerNumber")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Airlines");
                });

            modelBuilder.Entity("YehudaWebDev.Models.Airplanes", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("AirplaneAirlineId")
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("AirplaneModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("BusinessSeats")
                        .HasColumnType("int");

                    b.Property<int>("EcoeconomySeats")
                        .HasColumnType("int");

                    b.Property<int>("ManufactureYear")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("AirplaneAirlineId");

                    b.ToTable("Airplanes");
                });

            modelBuilder.Entity("YehudaWebDev.Models.Airport", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("AirportAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirportCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirportCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirportName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AirportSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.ToTable("Airport");
                });

            modelBuilder.Entity("YehudaWebDev.Models.Airplanes", b =>
                {
                    b.HasOne("YehudaWebDev.Models.Airlines", "AirplaneAirline")
                        .WithMany("AirlineAirplanes")
                        .HasForeignKey("AirplaneAirlineId");
                });
#pragma warning restore 612, 618
        }
    }
}
