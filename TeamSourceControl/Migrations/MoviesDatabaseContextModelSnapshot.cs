﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamSourceControl.Models;

#nullable disable

namespace TeamSourceControl.Migrations
{
    [DbContext(typeof(MoviesDatabaseContext))]
    partial class MoviesDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeamSourceControl.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"));

                    b.Property<string>("ActorFirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("ActorFollowed")
                        .HasColumnType("bit");

                    b.Property<string>("ActorLastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.HasKey("ActorId")
                        .HasName("PK__Actors__57B3EA4B4D9AE7A8");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("TeamSourceControl.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("MovieGenre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MovieStatus")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("smalldatetime");

                    b.Property<TimeSpan>("RunTime")
                        .HasColumnType("time");

                    b.HasKey("MovieId")
                        .HasName("PK__Movies__4BD2941ADFEF8AD8");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("TeamSourceControl.Models.MoviesWithActor", b =>
                {
                    b.Property<int?>("ActorId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MoviesWithActors");
                });

            modelBuilder.Entity("TeamSourceControl.Models.MoviesWithActor", b =>
                {
                    b.HasOne("TeamSourceControl.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .HasConstraintName("FK__MoviesWit__Actor__2A4B4B5E");

                    b.HasOne("TeamSourceControl.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .HasConstraintName("FK__MoviesWit__Movie__29572725");

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
