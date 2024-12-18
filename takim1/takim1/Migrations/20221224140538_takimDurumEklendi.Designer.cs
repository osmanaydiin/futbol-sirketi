﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using takim1.Models;

#nullable disable

namespace takim1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221224140538_takimDurumEklendi")]
    partial class takimDurumEklendi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("takim1.Models.Futbolcu", b =>
                {
                    b.Property<int>("FutbolcuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FutbolcuId"));

                    b.Property<string>("FutbolcuAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FutbolcuDeger")
                        .HasColumnType("real");

                    b.Property<string>("FutbolcuGecmis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FutbolcuMaas")
                        .HasColumnType("real");

                    b.Property<string>("FutbolcuMevki")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FutbolcuNumara")
                        .HasColumnType("int");

                    b.Property<string>("FutbolcuResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FutbolcuSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FutbolcuYas")
                        .HasColumnType("int");

                    b.Property<int>("TakimId")
                        .HasColumnType("int");

                    b.HasKey("FutbolcuId");

                    b.HasIndex("TakimId");

                    b.ToTable("Futbolcular");
                });

            modelBuilder.Entity("takim1.Models.Takim", b =>
                {
                    b.Property<int>("TakimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TakimId"));

                    b.Property<string>("TakimAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TakimDeger")
                        .HasColumnType("real");

                    b.Property<bool>("TakimDurum")
                        .HasColumnType("bit");

                    b.Property<int>("TakimKurulus")
                        .HasColumnType("int");

                    b.Property<string>("TakimResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TakimSampiyonluk")
                        .HasColumnType("int");

                    b.HasKey("TakimId");

                    b.ToTable("Takimlar");
                });

            modelBuilder.Entity("takim1.Models.TeknikDirektor", b =>
                {
                    b.Property<int>("TeknikDirektorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeknikDirektorId"));

                    b.Property<int>("TakimId")
                        .HasColumnType("int");

                    b.Property<string>("TeknikDirektorAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeknikDirektorGecmis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TeknikDirektorMaas")
                        .HasColumnType("real");

                    b.Property<string>("TeknikDirektorResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeknikDirektorSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeknikDirektorYas")
                        .HasColumnType("int");

                    b.HasKey("TeknikDirektorId");

                    b.HasIndex("TakimId");

                    b.ToTable("TeknikDirektorler");
                });

            modelBuilder.Entity("takim1.Models.Futbolcu", b =>
                {
                    b.HasOne("takim1.Models.Takim", "Takim")
                        .WithMany("Futbolcular")
                        .HasForeignKey("TakimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Takim");
                });

            modelBuilder.Entity("takim1.Models.TeknikDirektor", b =>
                {
                    b.HasOne("takim1.Models.Takim", "Takim")
                        .WithMany("TeknikDirektorler")
                        .HasForeignKey("TakimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Takim");
                });

            modelBuilder.Entity("takim1.Models.Takim", b =>
                {
                    b.Navigation("Futbolcular");

                    b.Navigation("TeknikDirektorler");
                });
#pragma warning restore 612, 618
        }
    }
}
