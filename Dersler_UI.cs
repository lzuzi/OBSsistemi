using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Dersler_UI
    {
        public int DersSayisi { get; set; }
        public Dersler_UI()
        {
            DersSayisi = 0;
        }

        public static void dersGoster()
        {



        }

        public static void DersleriYazdir()
        {

            Console.Clear();
            Console.WriteLine("\t~Adı~\t\t~Kodu~");
            Console.WriteLine("--------------------------------------------------------------------------------");
            if (OBS.dersler.Count > 0)
            {
                for (int i = 0; i < OBS.dersler.Count; i++)
                {
                    Console.WriteLine($"{i + 1} -> \t{OBS.dersler[i].Ad}\t\t{OBS.dersler[i].Kod}");
                }
            }
            else
            {
                Console.WriteLine("Ders Bulunamadı.");
            }
        }


    }
}
