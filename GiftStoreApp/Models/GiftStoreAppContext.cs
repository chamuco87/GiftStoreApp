using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GiftStoreApp.Models
{
    public partial class GiftStoreAppContext : DbContext
    {
        public virtual DbSet<GlobalSettings> GlobalSettings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=tcp:giftstoreapp.database.windows.net,1433;Initial Catalog=GiftStoreApp;Persist Security Info=False;User ID=chamuco87;Password=Lom@s246;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GlobalSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .IsUnicode(false);
            });
        }
    }
}
