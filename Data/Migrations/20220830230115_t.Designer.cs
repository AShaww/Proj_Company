﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20220830230115_t")]
    partial class t
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("EmployeeDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("JobRoleId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("JobRoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            EmployeeDetailsId = 1,
                            FirstName = "Pepper",
                            GenderId = 2,
                            JobRoleId = 2,
                            LastName = "Potts"
                        },
                        new
                        {
                            EmployeeId = 2,
                            EmployeeDetailsId = 2,
                            FirstName = "Amelia",
                            GenderId = 2,
                            JobRoleId = 2,
                            LastName = "Kent"
                        },
                        new
                        {
                            EmployeeId = 3,
                            EmployeeDetailsId = 3,
                            FirstName = "Jane",
                            GenderId = 2,
                            JobRoleId = 3,
                            LastName = "Dough"
                        },
                        new
                        {
                            EmployeeId = 4,
                            EmployeeDetailsId = 4,
                            FirstName = "Booklyn",
                            GenderId = 2,
                            JobRoleId = 4,
                            LastName = "Street"
                        },
                        new
                        {
                            EmployeeId = 5,
                            EmployeeDetailsId = 5,
                            FirstName = "Robin",
                            GenderId = 2,
                            JobRoleId = 5,
                            LastName = "Steal'ums"
                        },
                        new
                        {
                            EmployeeId = 6,
                            EmployeeDetailsId = 6,
                            FirstName = "Luke",
                            GenderId = 1,
                            JobRoleId = 1,
                            LastName = "Skycrawler"
                        },
                        new
                        {
                            EmployeeId = 7,
                            EmployeeDetailsId = 7,
                            FirstName = "Rob",
                            GenderId = 1,
                            JobRoleId = 7,
                            LastName = "Banks"
                        },
                        new
                        {
                            EmployeeId = 8,
                            EmployeeDetailsId = 8,
                            FirstName = "Resta",
                            GenderId = 1,
                            JobRoleId = 8,
                            LastName = "Soul"
                        },
                        new
                        {
                            EmployeeId = 9,
                            EmployeeDetailsId = 9,
                            FirstName = "Amir",
                            GenderId = 1,
                            JobRoleId = 9,
                            LastName = "Shaw"
                        },
                        new
                        {
                            EmployeeId = 10,
                            EmployeeDetailsId = 10,
                            FirstName = "Jack",
                            GenderId = 1,
                            JobRoleId = 9,
                            LastName = "Daniels"
                        });
                });

            modelBuilder.Entity("Models.Entities.EmployeeDetails", b =>
                {
                    b.Property<int>("EmployeeDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeDetailsId");

                    b.ToTable("EmployeeDetails");

                    b.HasData(
                        new
                        {
                            EmployeeDetailsId = 1,
                            Address = "31 Street",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 2,
                            Address = "Flat 921a, Monty Road",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 3,
                            Address = "6 Sewer Lake",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 4,
                            Address = "2 Random Cave Entrance",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 5,
                            Address = "24 Bobs Hut",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 6,
                            Address = "53 Deck of Houses",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 7,
                            Address = "12 Word on the street",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 8,
                            Address = "534 Maybe Im good at this? Road",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 9,
                            Address = "92 Lavender park",
                            MobileNumber = "+447982892893"
                        },
                        new
                        {
                            EmployeeDetailsId = 10,
                            Address = "EYY 9b Hey mamba Lane",
                            MobileNumber = "+447982892893"
                        });
                });

            modelBuilder.Entity("Models.Entities.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            GenderName = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            GenderName = "Female"
                        });
                });

            modelBuilder.Entity("Models.Entities.JobRole", b =>
                {
                    b.Property<int>("JobRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobRoleId"), 1L, 1);

                    b.Property<string>("JobRoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobRoleId");

                    b.ToTable("JobRoles");

                    b.HasData(
                        new
                        {
                            JobRoleId = 1,
                            JobRoleTitle = "Illuminati"
                        },
                        new
                        {
                            JobRoleId = 2,
                            JobRoleTitle = "CEO"
                        },
                        new
                        {
                            JobRoleId = 3,
                            JobRoleTitle = "CTO"
                        },
                        new
                        {
                            JobRoleId = 4,
                            JobRoleTitle = "C3PO"
                        },
                        new
                        {
                            JobRoleId = 5,
                            JobRoleTitle = "Head of Department"
                        },
                        new
                        {
                            JobRoleId = 6,
                            JobRoleTitle = "Manager"
                        },
                        new
                        {
                            JobRoleId = 7,
                            JobRoleTitle = "Supervisor"
                        },
                        new
                        {
                            JobRoleId = 8,
                            JobRoleTitle = "Lacky"
                        },
                        new
                        {
                            JobRoleId = 9,
                            JobRoleTitle = "Coffee Boy"
                        });
                });

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.HasOne("Models.Entities.Gender", "Gender")
                        .WithMany("Employees")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.JobRole", "JobRole")
                        .WithMany("Employees")
                        .HasForeignKey("JobRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("JobRole");
                });

            modelBuilder.Entity("Models.Entities.EmployeeDetails", b =>
                {
                    b.HasOne("Models.Entities.Employee", "Employee")
                        .WithOne("EmployeeDetail")
                        .HasForeignKey("Models.Entities.EmployeeDetails", "EmployeeDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Entities.Gender", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Models.Entities.JobRole", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}