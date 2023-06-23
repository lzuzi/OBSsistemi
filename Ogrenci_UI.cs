using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Ogrenci_UI
    {
        public Ogrenci_UI()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
        }

        public static void OgrenciGoster(Ogrenci ogrenci)
        {

        }
        public static void BilgiYazdir(Ogrenci ogrenci)
        {
            Console.WriteLine($"Ad Soyad: \t{ogrenci.AdSoyad}");
            Console.WriteLine($"Numarası: \t{ogrenci.OgrenciNo}");
            Console.WriteLine($"Bölümü: \t{ogrenci.Bolum}");
            Console.WriteLine($"TCKNO'su: \t{ogrenci.TCKNO}\n");
            Console.WriteLine("Aldığı Dersler: ");

            if (ogrenci.AldigiDersler.Count != 0)
            {
                for (int i = 0; i < ogrenci.AldigiDersler.Count; i++)
                {
                    if (ogrenci.AldigiDersler[i] != null)
                        Console.WriteLine($"-> {ogrenci.AldigiDersler[i].Ad} ({ogrenci.AldigiDersler[i].Kod})");
                    else
                        continue;
                }
            }
            else
                Console.WriteLine("Öğrenci ders almıyor.");
        }


        /*
        public static void BilgiYazdir()
        {
            Console.WriteLine("Öğrenci Numarası: ");
            string ogrenciNo = Console.ReadLine();

            Ogrenci ogrenci = Ogrenci_Service.OgrenciBul(ogrenciNo);

            Console.WriteLine($"Adı: {ogrenci.AdSoyad}");
            Console.WriteLine($"Numarası: {ogrenci.OgrenciNo}");
            Console.WriteLine($"Bölümü: {ogrenci.Bolum}");
            Console.WriteLine($"TCKNO'su: {ogrenci.TCKNO}");
            Console.WriteLine("Aldığı Dersler: ");

            if (ogrenci.AldigiDersler.Count != 0)
            {
                for (int i = 0; i < ogrenci.AldigiDersler.Count; i++)
                {
                    if (ogrenci.AldigiDersler[i] != null)
                        Console.WriteLine($"{i + 1}-> {ogrenci.AldigiDersler[i].Ad}");
                    else
                        continue;
                }
            }
            else
                Console.WriteLine("Öğrenci ders almıyor.");
        }
        */

        public static void OgrencileriYazdir()
        {
            Console.Clear();
            Console.WriteLine("\t~Adı\t\t~Numarası~\t\t~Bölümü~\t~TCKNO~");
            Console.WriteLine("--------------------------------------------------------------------------------");
            if (OBS.ogrenciler.Count > 0)
            {
                for (int i = 0; i < OBS.ogrenciler.Count; i++)
                {
                    Console.WriteLine($"{i + 1} -> \t{OBS.ogrenciler[i].AdSoyad}\t{OBS.ogrenciler[i].OgrenciNo}\t\t{OBS.ogrenciler[i].Bolum}\t\t{OBS.ogrenciler[i].TCKNO}");
                }
            }
            else
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }
        public static void SinavlariYazdir(Ogrenci ogrenci)
        {
            ogrenci.GirecegiSinavlar.ForEach(a => Console.WriteLine(a.ders));
            Console.ReadKey();
        }

    }
}
