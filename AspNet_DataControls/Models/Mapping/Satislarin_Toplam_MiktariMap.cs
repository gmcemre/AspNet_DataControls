using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNet_DataControls.Models.Mapping
{
    public class Satislarin_Toplam_MiktariMap : EntityTypeConfiguration<Satislarin_Toplam_Miktari>
    {
        public Satislarin_Toplam_MiktariMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SatisID, t.SirketAdi });

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SirketAdi)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Satislarin Toplam Miktari");
            this.Property(t => t.SaleAmount).HasColumnName("SaleAmount");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
            this.Property(t => t.SevkTarihi).HasColumnName("SevkTarihi");
        }
    }
}
