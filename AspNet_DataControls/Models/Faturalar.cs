using System;
using System.Collections.Generic;

namespace AspNet_DataControls.Models
{
    public partial class Faturalar
    {
        public string SevkAdi { get; set; }
        public string SevkAdresi { get; set; }
        public string SevkSehri { get; set; }
        public string SevkBolgesi { get; set; }
        public string SevkPostaKodu { get; set; }
        public string SevkUlkesi { get; set; }
        public string MusteriID { get; set; }
        public string MusteriName { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string PersonelSatislari { get; set; }
        public int SatisID { get; set; }
        public Nullable<System.DateTime> SatisTarihi { get; set; }
        public Nullable<System.DateTime> OdemeTarihi { get; set; }
        public Nullable<System.DateTime> SevkTarihi { get; set; }
        public string NakliyeciName { get; set; }
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public short Miktar { get; set; }
        public float İndirim { get; set; }
        public Nullable<decimal> ExtendedPrice { get; set; }
        public Nullable<decimal> NakliyeUcreti { get; set; }
    }
}
