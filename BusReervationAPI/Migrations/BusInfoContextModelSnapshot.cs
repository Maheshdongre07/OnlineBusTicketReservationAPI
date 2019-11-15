﻿// <auto-generated />
using System;
using BusReervationAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusReervationAPI.Migrations
{
    [DbContext(typeof(BusInfoContext))]
    partial class BusInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BusReervationAPI.Models.BusInfo", b =>
                {
                    b.Property<int>("BusInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusArrivalTime");

                    b.Property<string>("BusDepartureTime");

                    b.Property<double>("BusFare");

                    b.Property<string>("BusType")
                        .IsRequired();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("FromLocation")
                        .IsRequired();

                    b.Property<int>("TicketsCount");

                    b.Property<string>("ToLocation")
                        .IsRequired();

                    b.Property<DateTime>("TravelDate");

                    b.HasKey("BusInfoId");

                    b.ToTable("BusInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
