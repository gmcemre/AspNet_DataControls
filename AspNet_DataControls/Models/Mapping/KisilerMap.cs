using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace AspNet_DataControls.Models.Mapping
{
    public class KisilerMap : EntityTypeConfiguration<Kisiler>
    {
        public KisilerMap()
        {
            // Primary Key
            this.HasKey(t => t.KisiID);

            // Properties
            this.Property(t => t.KisiSoyadi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Sehir)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Kisiler");
            this.Property(t => t.KisiID).HasColumnName("KisiID");
            this.Property(t => t.KisiSoyadi).HasColumnName("KisiSoyadi");
            this.Property(t => t.Sehir).HasColumnName("Sehir");
        }
    }
}
