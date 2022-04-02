using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace AspNet_DataControls.Models.Mapping
{
    public class UrunResimMap : EntityTypeConfiguration<UrunResim>
    {
        public UrunResimMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Resim)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("UrunResim");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.Resim).HasColumnName("Resim");
            this.Property(t => t.IsActive).HasColumnName("IsActive");

            // Relationships
            this.HasRequired(t => t.Urunler)
                .WithMany(t => t.UrunResims)
                .HasForeignKey(d => d.UrunID);

        }
    }
}
