﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetCare_BackEnd.Data;

#nullable disable

namespace VetCare_BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240911155635_CreatingFalseDatafortheAppointmentTypesTable")]
    partial class CreatingFalseDatafortheAppointmentTypesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VetCare_BackEnd.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(260)
                        .HasColumnType("varchar(260)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentTypeId = 2,
                            Available = false,
                            Description = "cardiology",
                            EndDate = new DateOnly(2023, 8, 23),
                            PetId = 1,
                            StartDate = new DateOnly(2023, 8, 22)
                        },
                        new
                        {
                            Id = 2,
                            AppointmentTypeId = 1,
                            Available = true,
                            EndDate = new DateOnly(2023, 7, 23),
                            PetId = 2,
                            StartDate = new DateOnly(2023, 7, 22)
                        },
                        new
                        {
                            Id = 3,
                            AppointmentTypeId = 2,
                            Available = false,
                            Description = "cardiology",
                            EndDate = new DateOnly(2023, 6, 23),
                            PetId = 3,
                            StartDate = new DateOnly(2023, 6, 22)
                        },
                        new
                        {
                            Id = 4,
                            AppointmentTypeId = 1,
                            Available = true,
                            EndDate = new DateOnly(2023, 5, 23),
                            PetId = 4,
                            StartDate = new DateOnly(2023, 5, 22)
                        },
                        new
                        {
                            Id = 5,
                            AppointmentTypeId = 2,
                            Available = false,
                            Description = "cardiology",
                            EndDate = new DateOnly(2023, 4, 23),
                            PetId = 5,
                            StartDate = new DateOnly(2023, 4, 22)
                        },
                        new
                        {
                            Id = 6,
                            AppointmentTypeId = 1,
                            Available = true,
                            EndDate = new DateOnly(2023, 3, 23),
                            PetId = 6,
                            StartDate = new DateOnly(2023, 3, 22)
                        },
                        new
                        {
                            Id = 7,
                            AppointmentTypeId = 2,
                            Available = false,
                            Description = "cardiology",
                            EndDate = new DateOnly(2023, 2, 23),
                            PetId = 6,
                            StartDate = new DateOnly(2023, 2, 22)
                        },
                        new
                        {
                            Id = 8,
                            AppointmentTypeId = 1,
                            Available = true,
                            EndDate = new DateOnly(2023, 1, 23),
                            PetId = 7,
                            StartDate = new DateOnly(2023, 1, 22)
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.AppointmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("appointmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "consult"
                        },
                        new
                        {
                            Id = 2,
                            Name = "exam"
                        },
                        new
                        {
                            Id = 3,
                            Name = "appointment"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("documentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cédula de Ciudadanía"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tarjeta de Identidad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pasaporte"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Número de Identificación Tributaria"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cédula de Extranjería"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Registro Civil"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Permiso Especial de Permanencia"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasMaxLength(10)
                        .HasColumnType("date");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("pets");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(2024, 2, 9),
                            Breed = "yorkie",
                            Name = "apolo",
                            Sex = "male",
                            Weight = "10lbs",
                            user_id = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateOnly(2024, 3, 12),
                            Breed = "border colie",
                            Name = "princesa",
                            Sex = "female",
                            Weight = "7lbs",
                            user_id = 2
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateOnly(2024, 4, 23),
                            Breed = "pomerania",
                            Name = "cookie",
                            Sex = "male",
                            Weight = "3lbs",
                            user_id = 3
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateOnly(2024, 5, 4),
                            Breed = "bulldog",
                            Name = "motas",
                            Sex = "female",
                            Weight = "12lbs",
                            user_id = 4
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateOnly(2024, 6, 3),
                            Breed = "creole",
                            Name = "coco",
                            Sex = "male",
                            Weight = "6lbs",
                            user_id = 5
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateOnly(2024, 7, 2),
                            Breed = "creole",
                            Name = "romeo",
                            Sex = "female",
                            Weight = "8lbs",
                            user_id = 6
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateOnly(2024, 8, 1),
                            Breed = "yorkie",
                            Name = "kira",
                            Sex = "male",
                            Weight = "9lbs",
                            user_id = 7
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateOnly(2023, 12, 11),
                            DocumentNumber = "obnlia8eyh",
                            DocumentTypeId = 2,
                            Email = "Myrl51@yahoo.com",
                            LastName = "Botsford",
                            Name = "Garnett",
                            Password = "AzqlRdErLu",
                            PhoneNumber = "711 597 49 32",
                            RoleId = 5
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(2024, 2, 25),
                            DocumentNumber = "v518o2o2ja",
                            DocumentTypeId = 1,
                            Email = "Gianni_Beahan56@hotmail.com",
                            LastName = "Crist",
                            Name = "Tracy",
                            Password = "6xzTe1OvO8",
                            PhoneNumber = "684 785 47 69",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateOnly(2023, 12, 24),
                            DocumentNumber = "uuhaq4wn9c",
                            DocumentTypeId = 5,
                            Email = "Ellie_West@gmail.com",
                            LastName = "MacGyver",
                            Name = "Carlee",
                            Password = "GXoC57lCI8",
                            PhoneNumber = "522 747 54 13",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateOnly(2023, 11, 8),
                            DocumentNumber = "5t8zuoicgt",
                            DocumentTypeId = 1,
                            Email = "Omer.Will30@yahoo.com",
                            LastName = "Littel",
                            Name = "Mose",
                            Password = "na_5zmuOVv",
                            PhoneNumber = "979 031 20 76",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateOnly(2023, 11, 22),
                            DocumentNumber = "32mth3ofqk",
                            DocumentTypeId = 2,
                            Email = "Jasen_Mayer@hotmail.com",
                            LastName = "Gleason",
                            Name = "Albertha",
                            Password = "7ru59G7Wh1",
                            PhoneNumber = "680 393 16 91",
                            RoleId = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
