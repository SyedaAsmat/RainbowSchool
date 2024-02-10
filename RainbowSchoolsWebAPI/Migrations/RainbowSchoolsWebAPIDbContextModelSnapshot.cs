﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RainbowSchoolsWebAPI.Data;

#nullable disable

namespace RainbowSchoolsWebAPI.Migrations
{
    [DbContext(typeof(RainbowSchoolsWebAPIDbContext))]
    partial class RainbowSchoolsWebAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RainbowSchoolsWebAPI.Models.Marks", b =>
                {
                    b.Property<int>("MarksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarksId"), 1L, 1);

                    b.Property<int>("MarksObtained")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("MarksId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("RainbowSchoolsWebAPI.Models.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("RainbowSchoolsWebAPI.Models.Subjects", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("RainbowSchoolsWebAPI.Models.Marks", b =>
                {
                    b.HasOne("RainbowSchoolsWebAPI.Models.Students", "Students")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId");

                    b.HasOne("RainbowSchoolsWebAPI.Models.Subjects", "Subjects")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("RainbowSchoolsWebAPI.Models.Students", b =>
                {
                    b.Navigation("Marks");
                });

            modelBuilder.Entity("RainbowSchoolsWebAPI.Models.Subjects", b =>
                {
                    b.Navigation("Marks");
                });
#pragma warning restore 612, 618
        }
    }
}
