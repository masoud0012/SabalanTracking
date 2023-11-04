﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SabalanTracking.Data;

#nullable disable

namespace SabalanTracking.Migrations
{
    [DbContext(typeof(TrackingDbContext))]
    [Migration("20231104024721_unit")]
    partial class unit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SabalanTracking.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Devices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "خرید"
                        },
                        new
                        {
                            Id = 2,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "فروش"
                        },
                        new
                        {
                            Id = 3,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "دستگاه جوش التراسونیک"
                        },
                        new
                        {
                            Id = 4,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "دستگاه برش التراسونیک پارچه"
                        },
                        new
                        {
                            Id = 5,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "دستگاه تزریق شماره مهاباد"
                        },
                        new
                        {
                            Id = 6,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "دستگاه تزریق شماره عباسی"
                        },
                        new
                        {
                            Id = 7,
                            Description = " ",
                            DeviceSN = "SN",
                            Name = "دستگاه سیلر بسته بندی"
                        });
                });

            modelBuilder.Entity("SabalanTracking.Models.Formulla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Formulas", (string)null);
                });

            modelBuilder.Entity("SabalanTracking.Models.FormullaDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FormullaId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<double>("quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FormullaId");

                    b.HasIndex("MaterialId");

                    b.ToTable("FormullaDetails", (string)null);
                });

            modelBuilder.Entity("SabalanTracking.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.HasIndex("UnitId");

                    b.ToTable("Materials", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatId = 2,
                            Name = "فیلتر HME",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 2,
                            CatId = 2,
                            Name = "فیلتر VFE",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 3,
                            CatId = 2,
                            Name = "فیلتر اسپیرومتری",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 4,
                            CatId = 3,
                            Name = "فیلتر ویپک HME",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 5,
                            CatId = 3,
                            Name = "ویپک VFE",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 6,
                            CatId = 3,
                            Name = "ویپک اسپیرومتری",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 7,
                            CatId = 3,
                            Name = "بدنه فیلتر اچ ام ای بدون درپوش",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 8,
                            CatId = 3,
                            Name = "بدنه فیلتر اچ ام ای با درپوش",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 9,
                            CatId = 3,
                            Name = "درپوش",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 10,
                            CatId = 3,
                            Name = "بدنه فیلتر آنتی باکتریال با درپوش",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 11,
                            CatId = 3,
                            Name = "بدنه فیلتر آنتی باکتریال بدون درپوش",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 12,
                            CatId = 3,
                            Name = "بدنه فیلتر اسپیرومتری شماره 1",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 13,
                            CatId = 3,
                            Name = "بدنه فیلتر اسپیرومتری شماره 2",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 14,
                            CatId = 1,
                            Name = "پلی استایرن-PS",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 15,
                            CatId = 1,
                            Name = "پلی پروپیلن-PP",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 16,
                            CatId = 1,
                            Name = "PVC",
                            UnitId = 1
                        },
                        new
                        {
                            Id = 17,
                            CatId = 1,
                            Name = "کاغذ جاذب رطوبت",
                            UnitId = 2
                        },
                        new
                        {
                            Id = 18,
                            CatId = 1,
                            Name = "ملت بلون",
                            UnitId = 3
                        },
                        new
                        {
                            Id = 19,
                            CatId = 1,
                            Name = "اسپان باند",
                            UnitId = 3
                        });
                });

            modelBuilder.Entity("SabalanTracking.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "",
                            Email = "",
                            Name = "عباسی",
                            Phone = ""
                        },
                        new
                        {
                            Id = 2,
                            Address = "",
                            Email = "",
                            Name = "پژمان",
                            Phone = ""
                        },
                        new
                        {
                            Id = 3,
                            Address = "",
                            Email = "",
                            Name = "مهندس عبدالله پور",
                            Phone = ""
                        },
                        new
                        {
                            Id = 4,
                            Address = "",
                            Email = "",
                            Name = "مسعود",
                            Phone = ""
                        },
                        new
                        {
                            Id = 5,
                            Address = "",
                            Email = "",
                            Name = "رضا",
                            Phone = ""
                        },
                        new
                        {
                            Id = 6,
                            Address = "",
                            Email = "",
                            Name = "اپراتور 1 عباسی",
                            Phone = ""
                        },
                        new
                        {
                            Id = 7,
                            Address = "",
                            Email = "",
                            Name = "اپراتور 2 عبداللهی",
                            Phone = ""
                        });
                });

            modelBuilder.Entity("SabalanTracking.Models.Proces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("ProcessNameId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("SN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ProcessNameId");

                    b.ToTable("Processes", (string)null);
                });

            modelBuilder.Entity("SabalanTracking.Models.ProcessDetaile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<string>("Product_SN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("QntyPerPc")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.ToTable("ProcessDetails", (string)null);
                });

            modelBuilder.Entity("SabalanTracking.Models.ProcessName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("ProcessNames", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "خرید"
                        },
                        new
                        {
                            Id = 2,
                            Name = "فروش"
                        },
                        new
                        {
                            Id = 3,
                            Name = "برش پارچه"
                        },
                        new
                        {
                            Id = 4,
                            Name = "تزریق پلاستیک"
                        },
                        new
                        {
                            Id = 5,
                            Name = "جوش التراسونیک"
                        },
                        new
                        {
                            Id = 6,
                            Name = "بسته بندی"
                        });
                });

            modelBuilder.Entity("SabalanTracking.Models.ProductCat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("ProductCats", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "RawMaterial"
                        },
                        new
                        {
                            Id = 2,
                            Category = "FinalProduct"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Semi Final Prodct"
                        });
                });

            modelBuilder.Entity("SabalanTracking.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "کیلوگرم"
                        },
                        new
                        {
                            Id = 2,
                            Name = "عدد"
                        },
                        new
                        {
                            Id = 3,
                            Name = "متر"
                        });
                });

            modelBuilder.Entity("SabalanTracking.Models.Formulla", b =>
                {
                    b.HasOne("SabalanTracking.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("SabalanTracking.Models.FormullaDetails", b =>
                {
                    b.HasOne("SabalanTracking.Models.Formulla", "Formula")
                        .WithMany("formullaDetails")
                        .HasForeignKey("FormullaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SabalanTracking.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Formula");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("SabalanTracking.Models.Material", b =>
                {
                    b.HasOne("SabalanTracking.Models.ProductCat", "ProductCat")
                        .WithMany("Materials")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SabalanTracking.Models.Unit", "Unit")
                        .WithMany("Materials")
                        .HasForeignKey("UnitId");

                    b.Navigation("ProductCat");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("SabalanTracking.Models.Proces", b =>
                {
                    b.HasOne("SabalanTracking.Models.Device", "Device")
                        .WithMany("Processs")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SabalanTracking.Models.Material", "Material")
                        .WithMany("Processs")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SabalanTracking.Models.Person", "Person")
                        .WithMany("Processs")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SabalanTracking.Models.ProcessName", "ProcessName")
                        .WithMany()
                        .HasForeignKey("ProcessNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Material");

                    b.Navigation("Person");

                    b.Navigation("ProcessName");
                });

            modelBuilder.Entity("SabalanTracking.Models.ProcessDetaile", b =>
                {
                    b.HasOne("SabalanTracking.Models.Proces", "Process")
                        .WithMany("ProcessDetails")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");
                });

            modelBuilder.Entity("SabalanTracking.Models.Device", b =>
                {
                    b.Navigation("Processs");
                });

            modelBuilder.Entity("SabalanTracking.Models.Formulla", b =>
                {
                    b.Navigation("formullaDetails");
                });

            modelBuilder.Entity("SabalanTracking.Models.Material", b =>
                {
                    b.Navigation("Processs");
                });

            modelBuilder.Entity("SabalanTracking.Models.Person", b =>
                {
                    b.Navigation("Processs");
                });

            modelBuilder.Entity("SabalanTracking.Models.Proces", b =>
                {
                    b.Navigation("ProcessDetails");
                });

            modelBuilder.Entity("SabalanTracking.Models.ProductCat", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("SabalanTracking.Models.Unit", b =>
                {
                    b.Navigation("Materials");
                });
#pragma warning restore 612, 618
        }
    }
}
