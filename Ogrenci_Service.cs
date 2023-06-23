using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Ogrenci_Service
    {
        public static Ogrenci OgrenciBul(string OgrenciNo_)
        {
            Ogrenci ogrenci = new Ogrenci();


            for (int i = 0; i < OBS.ogrenciler.Count; i++)
            {
                if (OBS.ogrenciler[i].OgrenciNo == OgrenciNo_)
                {
                    ogrenci = OBS.ogrenciler[i];
                    break;
                }
            }
            if (ogrenci.OgrenciNo != null)
                return ogrenci;
            else
                return null;
        }
    }
}
