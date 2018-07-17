using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PBaseReactVS.Models
{
    public partial class DBBaseReactContext : DbContext
    {
        public DBBaseReactContext()
        {
        }

        public DBBaseReactContext(DbContextOptions<DBBaseReactContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmArea> AdmArea { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DELL09\\SQLEXPRESS;Initial Catalog=DBBaseReact;Persist Security Info=true;User Id=sa;Password=p81bG8f7;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmArea>(entity =>
            {
                entity.HasKey(e => e.IdArea);

                entity.Property(e => e.NomArea)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
