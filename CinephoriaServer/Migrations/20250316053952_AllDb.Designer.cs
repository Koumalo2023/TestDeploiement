﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CinephoriaServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250316053952_AllDb")]
    partial class AllDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AppUserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("AppUserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("integer");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Borrowing", b =>
                {
                    b.Property<int>("BorrowingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BorrowingId"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("BorrowingId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BookId");

                    b.ToTable("Borrowings");
                });

            modelBuilder.Entity("Borrowing", b =>
                {
                    b.HasOne("AppUser", "AppUser")
                        .WithMany("Borrowings")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book", "Book")
                        .WithMany("Borrowings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("AppUser", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("Book", b =>
                {
                    b.Navigation("Borrowings");
                });
#pragma warning restore 612, 618
        }
    }
}
