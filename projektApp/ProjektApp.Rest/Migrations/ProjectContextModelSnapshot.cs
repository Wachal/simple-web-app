﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektApp.Rest.Database;

#nullable disable

namespace ProjektApp.Rest.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjektApp.Rest.Database.Entities.CardEntity", b =>
                {
                    b.Property<int>("CardEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardEntryId"), 1L, 1);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("CardEntryId");

                    b.ToTable("CardEntries", (string)null);
                });

            modelBuilder.Entity("ProjektApp.Rest.Database.Entities.CardTimesEntity", b =>
                {
                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TimeInSeconds")
                        .HasColumnType("int");

                    b.ToTable("CardTimes");
                });

            modelBuilder.Entity("ProjektApp.Rest.Database.Entities.PersonEntity", b =>
                {
                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardNumber");

                    b.ToTable("Person", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
