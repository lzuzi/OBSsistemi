using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Sinav
    {
        public Ders ders { get; set; }
        public String Tarih { get; set; }
        public List<Ogrenci> GirecekOgrenciler { get; set; }

        public Sinav()
        {
            GirecekOgrenciler = new List<Ogrenci>();
        }

    }
}
