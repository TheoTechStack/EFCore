﻿// <auto-generated />
using System;
using EfCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCore.Data.Migrations
{
    [DbContext(typeof(FootballLeagueDbContext))]
    [Migration("20240811140239_SeededTeams")]
    partial class SeededTeams
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("EfCore.Domain.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("EfCore.Domain.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            CreatedDate = new DateTime(2024, 8, 11, 14, 2, 39, 526, DateTimeKind.Unspecified).AddTicks(3560),
                            Name = "Manchester FC"
                        },
                        new
                        {
                            TeamId = 2,
                            CreatedDate = new DateTime(2024, 8, 11, 14, 2, 39, 526, DateTimeKind.Unspecified).AddTicks(3570),
                            Name = "Juventus"
                        },
                        new
                        {
                            TeamId = 3,
                            CreatedDate = new DateTime(2024, 8, 11, 14, 2, 39, 526, DateTimeKind.Unspecified).AddTicks(3570),
                            Name = "Chelsea"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
