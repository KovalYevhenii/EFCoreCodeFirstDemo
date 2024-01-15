﻿// <auto-generated />
using System;
using EFCoreCodeFirstDemoApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreCodeFirstDemoApp.Migrations
{
    [DbContext(typeof(EFCoreDbContext))]
    [Migration("20240114122102_TryChangeName")]
    partial class TryChangeName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EFCoreCodeFirstDemoApp.Entities.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StandardId"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("StandardName")
                        .HasColumnType("text");

                    b.HasKey("StandardId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("EFCoreCodeFirstDemoApp.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18, 4)")
                        .HasColumnName("Hight");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("StandardId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18, 4)");

                    b.HasKey("StudentId");

                    b.HasIndex("StandardId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreCodeFirstDemoApp.Entities.Student", b =>
                {
                    b.HasOne("EFCoreCodeFirstDemoApp.Entities.Standard", "Standard")
                        .WithMany("Students")
                        .HasForeignKey("StandardId");

                    b.Navigation("Standard");
                });

            modelBuilder.Entity("EFCoreCodeFirstDemoApp.Entities.Standard", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
