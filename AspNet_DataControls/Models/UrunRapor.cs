using System;
using System.Collections.Generic;

namespace AspNet_DataControls.Models
{
    public partial class UrunRapor
    {
        public string UrunAdi { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<short> HedefStokDuzeyi { get; set; }
        public string KategoriAdi { get; set; }
        public string SirketAdi { get; set; }
    }
}
