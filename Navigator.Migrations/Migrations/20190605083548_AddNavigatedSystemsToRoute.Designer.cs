﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Navigator.DAL;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Navigator.Migrations.Migrations
{
    [DbContext(typeof(NavigatorContext))]
    [Migration("20190605083548_AddNavigatedSystemsToRoute")]
    partial class AddNavigatedSystemsToRoute
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Navigator.DAL.Navigator.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("From");

                    b.Property<string>("NavigatedSystems");

                    b.Property<int>("To");

                    b.HasKey("RouteId");

                    b.ToTable("Routes");
                });
#pragma warning restore 612, 618
        }
    }
}
