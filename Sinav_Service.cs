using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class Sinav_Service
    {
        OBS obs = new OBS();
        MenuManager menu = new MenuManager();
        public void SinavTanimla()
        {
            Sinav_Service SinavService = new Sinav_Service();
            Sinav sinav = new Sinav();

            Console.WriteLine("Sınavın dersinin adını giriniz:");
            string a = Console.ReadLine();
            Ders ders = Ders_Service.DersBul(a);
            sinav.ders = ders;

            Console.WriteLine("Sınavın tarihini giriniz:");
            sinav.Tarih = Console.ReadLine();

            Console.WriteLine("Sınav Tanımlandı.");

            OBS.sinavlar.Add(sinav);

        }
        public Sinav SinavBul(string ders)
        {
            Sinav sinav = new Sinav();

            for (int i = 0; i <= OBS.sinavlar.Count; i++)
            {
                if (i == OBS.sinavlar.Count)
                {
                    Console.WriteLine("Sınav bulunamadı.");
                    break;
                }
                if (OBS.sinavlar[i].ders.Ad == ders)
                {
                    sinav = OBS.sinavlar[i];
                    break;
                }
            }

            return sinav;
        }
        public void SinavMenuSecim()
        {
            Sinav_Service SinavService = new Sinav_Service();
            Console.WriteLine("Öğrenci Numarası giriniz: ");
            string x = Console.ReadLine();
            Ogrenci ogrenci = Ogrenci_Service.OgrenciBul(x);

            if (ogrenci != null)
            {
                bool go = true;


                while (go)
                {
                    try
                    {


                        Console.Clear();
                        Ogrenci_UI.BilgiYazdir(ogrenci);
                        menu.sinav_menuPrinter();

                        int secim2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        switch (secim2)
                        {
                            case 1:
                                OBS.OgrenciyeDersEkle(ogrenci.OgrenciNo);
                                Console.ReadKey();
                                break;
                            case 2:
                                OBS.OgrencidenDersSil(ogrenci.OgrenciNo);
                                Console.ReadKey();
                                break;
                            case 3:
                                break;
                            case 4:
                                OBS.OgrenciSil(ogrenci);
                                go = false;
                                Console.ReadKey();
                                break;
                            case 5:
                                go = false;
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception E)
                    {
                        Console.WriteLine("Yanlış girdi.");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamadı.");
                Console.ReadKey();
            }
        }
        public void OgrenciyeSinavEkle(Sinav sinav)
        {
            Console.WriteLine("Ogrenci numarasını giriniz: ");
            string a = Console.ReadLine();

            Ogrenci ogrenci = Ogrenci_Service.OgrenciBul(a);
            sinav.GirecekOgrenciler.Add(ogrenci);
            Console.WriteLine($"{sinav.ders.Ad}'dersinin sınav listesine {ogrenci.AdSoyad} eklendi");
        }

    }
}
