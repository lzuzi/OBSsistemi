using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Ogrenci
    {
        public String AdSoyad { get; set; }
        public String OgrenciNo { get; set; }
        public String TCKNO { get; set; }
        public String Bolum { get; set; }
        public List<Ders> AldigiDersler { get; set; }
        public int DersSayisi { get; set; }
        public List<Sinav> GirecegiSinavlar { get; set; }




        public Ogrenci()
        {
            AldigiDersler = new List<Ders>();
            GirecegiSinavlar = new List<Sinav>();
            DersSayisi = 0;
        }

    }
}
