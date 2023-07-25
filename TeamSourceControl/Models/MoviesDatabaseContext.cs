using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TeamSourceControl.Models;

public partial class MoviesDatabaseContext : DbContext
{
    public MoviesDatabaseContext()
    {
    }

    public MoviesDatabaseContext(DbContextOptions<MoviesDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MoviesWithActor> MoviesWithActors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MoviesDatabase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.ActorId).HasName("PK__Actors__57B3EA4B4D9AE7A8");

            entity.Property(e => e.ActorFirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ActorLastName)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK__Movies__4BD2941ADFEF8AD8");

            entity.Property(e => e.MovieGenre)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MovieName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MovieStatus)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseYear).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<MoviesWithActor>(entity =>
        {
            entity.HasNoKey();

            entity.HasOne(d => d.Actor).WithMany()
                .HasForeignKey(d => d.ActorId)
                .HasConstraintName("FK__MoviesWit__Actor__2A4B4B5E");

            entity.HasOne(d => d.Movie).WithMany()
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK__MoviesWit__Movie__29572725");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
