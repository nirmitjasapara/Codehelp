﻿// <auto-generated />
using System;
using CodehelpApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodehelpApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190223003915_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("CodehelpApp.API.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Answers");

                    b.Property<DateTime>("Created");

                    b.Property<string>("DisplayName");

                    b.Property<string>("QuestionDetails");

                    b.Property<string>("QuestionTitle");

                    b.Property<int>("UserId");

                    b.Property<int>("Views");

                    b.Property<int>("Votes");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("CodehelpApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CodehelpApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("CodehelpApp.API.Models.Question", b =>
                {
                    b.HasOne("CodehelpApp.API.Models.User", "User")
                        .WithMany("Questions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}