﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationINSAT.Models;

#nullable disable

namespace WebApplicationINSAT.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20241130174054_test4")]
    partial class test4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomersMovies", b =>
                {
                    b.Property<Guid>("CusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoviescId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CusId", "MoviescId");

                    b.HasIndex("MoviescId");

                    b.ToTable("CustomersMovies");
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Customers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MembershipId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MembershipId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Genres", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84ca0bcd-082c-49cb-aa77-ea2f1f5f8285"),
                            GenreName = "GenreFromJsonFile1"
                        },
                        new
                        {
                            Id = new Guid("79e6f638-d7e7-4f63-8365-f172cb925381"),
                            GenreName = "GenreFromJsonFile2"
                        });
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Membershiptypes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DiscountRate")
                        .HasColumnType("int");

                    b.Property<string>("DurationInMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SignUpFee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Membershiptypes");
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Movies", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Genre_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenresId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CustomersMovies", b =>
                {
                    b.HasOne("WebApplicationINSAT.Models.Customers", null)
                        .WithMany()
                        .HasForeignKey("CusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationINSAT.Models.Movies", null)
                        .WithMany()
                        .HasForeignKey("MoviescId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Customers", b =>
                {
                    b.HasOne("WebApplicationINSAT.Models.Membershiptypes", "Membership")
                        .WithMany("customers")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Movies", b =>
                {
                    b.HasOne("WebApplicationINSAT.Models.Genres", null)
                        .WithMany("Moviesg")
                        .HasForeignKey("GenresId");
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Genres", b =>
                {
                    b.Navigation("Moviesg");
                });

            modelBuilder.Entity("WebApplicationINSAT.Models.Membershiptypes", b =>
                {
                    b.Navigation("customers");
                });
#pragma warning restore 612, 618
        }
    }
}
