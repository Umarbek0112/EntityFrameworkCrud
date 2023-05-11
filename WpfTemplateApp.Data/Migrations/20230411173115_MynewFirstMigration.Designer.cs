﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WpfTemplateApp.Data.DbContexs;

#nullable disable

namespace WpfTemplateApp.Data.Migrations
{
    [DbContext(typeof(WpfTemplateAppDbContex))]
    [Migration("20230411173115_MynewFirstMigration")]
    partial class MynewFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int?>("CoursesId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("InsertAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CoursesId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.TeacherCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int?>("CoursesId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("InsertAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("TicherId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CoursesId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherCourses");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.TeacherStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("InsertAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherStudents");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Entities.Course.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("InsertAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Entities.Student.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<DateTime>("InsertAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int?>("StudentCourseId")
                        .HasColumnType("integer");

                    b.Property<int?>("TeacherStudentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("StudentCourseId");

                    b.HasIndex("TeacherStudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Entities.Teacher.Teachers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Info")
                        .HasColumnType("text");

                    b.Property<DateTime>("InsertAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int?>("TeacherCourseId")
                        .HasColumnType("integer");

                    b.Property<int?>("TeacherStudentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("TeacherCourseId");

                    b.HasIndex("TeacherStudentId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.StudentCourse", b =>
                {
                    b.HasOne("WpfTemplateApp.Domain.Entities.Course.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("WpfTemplateApp.Domain.Entities.Student.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.TeacherCourse", b =>
                {
                    b.HasOne("WpfTemplateApp.Domain.Entities.Course.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesId");

                    b.HasOne("WpfTemplateApp.Domain.Entities.Teacher.Teachers", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Courses");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.TeacherStudent", b =>
                {
                    b.HasOne("WpfTemplateApp.Domain.Entities.Student.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WpfTemplateApp.Domain.Entities.Teacher.Teachers", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Entities.Student.Student", b =>
                {
                    b.HasOne("WpfTemplateApp.Domain.Configurations.StudentCourse", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentCourseId");

                    b.HasOne("WpfTemplateApp.Domain.Configurations.TeacherStudent", null)
                        .WithMany("Students")
                        .HasForeignKey("TeacherStudentId");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Entities.Teacher.Teachers", b =>
                {
                    b.HasOne("WpfTemplateApp.Domain.Configurations.TeacherCourse", null)
                        .WithMany("Teachers")
                        .HasForeignKey("TeacherCourseId");

                    b.HasOne("WpfTemplateApp.Domain.Configurations.TeacherStudent", null)
                        .WithMany("Teachers")
                        .HasForeignKey("TeacherStudentId");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.StudentCourse", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.TeacherCourse", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("WpfTemplateApp.Domain.Configurations.TeacherStudent", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
