using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFScaffold;

public partial class PetsDbContext : DbContext
{
    public PetsDbContext()
    {
    }

    public PetsDbContext(DbContextOptions<PetsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;User Id=sa;Password=NotPassword@123;Database=master;Initial Catalog=PetsDB;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValue("");

            entity.HasMany(d => d.Pets).WithMany(p => p.Owners)
                .UsingEntity<Dictionary<string, object>>(
                    "OwnerPet",
                    r => r.HasOne<Pet>().WithMany().HasForeignKey("PetsId"),
                    l => l.HasOne<Owner>().WithMany().HasForeignKey("OwnersId"),
                    j =>
                    {
                        j.HasKey("OwnersId", "PetsId");
                        j.ToTable("OwnerPet");
                        j.HasIndex(new[] { "PetsId" }, "IX_OwnerPet_PetsId");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
