using System;
using System.Collections.Generic;

namespace AspNet_DataControls.Models
{
    public partial class Kategorilere_Gore_Urunler
    {
        public string KategoriAdi { get; set; }
        public string UrunAdi { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<short> HedefStokDuzeyi { get; set; }
        public bool Sonlandi { get; set; }
    }
}
