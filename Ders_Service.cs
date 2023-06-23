using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Ders_Service
    {
        public static Ders DersBul(string kod)
        {
            Ders ders = new Ders();

            for (int i = 0; i < OBS.dersler.Count; i++)
            {
                if (OBS.dersler[i].Kod == kod)
                {
                    ders = OBS.dersler[i];
                    break;
                }
            }
            return ders;
        }

    }
}
