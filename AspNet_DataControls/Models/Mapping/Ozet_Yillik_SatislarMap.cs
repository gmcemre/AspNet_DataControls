using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AspNet_DataControls.Models.Mapping
{
    public class Ozet_Yillik_SatislarMap : EntityTypeConfiguration<Ozet_Yillik_Satislar>
    {
        public Ozet_Yillik_SatislarMap()
        {
            // Primary Key
            this.HasKey(t => t.SatisID);

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ozet Yillik Satislar");
            this.Property(t => t.SevkTarihi).HasColumnName("SevkTarihi");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.Subtotal).HasColumnName("Subtotal");
        }
    }
}
