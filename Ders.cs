using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Ders
    {
        public String Kod { get; set; }
        public String Ad { get; set; }
        public List<Sinav> Sinavlar { get; set; }

        public Ders()
        {
            Sinavlar = new List<Sinav>();
        }
    }
}
