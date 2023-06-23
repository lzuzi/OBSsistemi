using System;

namespace örnek_OBS_sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Console.WriteLine("Silinecek sınavın dersini giriniz: ");
                //string b = Console.ReadLine();
                //Sinav sinav2 = SinavService.SinavBul(b);
                //ogrenci.GirecegiSinavlar.Remove(sinav2);
            } //sınav silme
            {
                //Console.WriteLine("Eklenecek sınavın dersinin adını giriniz: ");
                //string a = Console.ReadLine();
                //Sinav sinav = SinavService.SinavBul(a);
                //ogrenci.GirecegiSinavlar.Add(sinav);
                //Console.WriteLine($"{sinav.ders} dersinin sınavı {ogrenci.AdSoyad} öğrencisine eklendi.");
            } //sınav ekleme
            bool cont = true; //inf loop
            MenuManager menu = new MenuManager();
            Sinav_Service sinav = new Sinav_Service();




            OBS.debug_Tanim_ogr();
            OBS.debug_Tanim_ders();
            Console.WriteLine();

            while (cont)
            {
                try
                {
                    Console.Clear();
                    menu.menuPrinter();//menu
                    int secim = int.Parse(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            OBS.OgrenciTanimla();
                            Console.ReadKey();
                            break;


                        case 2:
                            OBS.YeniDersTanımla();
                            Console.ReadKey();
                            break;


                        case 3:
                            OBS.OgrenciyeDersEkle();
                            Console.ReadKey();
                            break;


                        case 4:
                            Ogrenci_UI.OgrencileriYazdir();
                            Console.ReadKey();
                            break;


                        case 5:
                            Dersler_UI.DersleriYazdir();
                            Console.ReadKey();
                            break;


                        case 6:
                            sinav.SinavMenuSecim();
                            break;


                        case 7:
                            sinav.SinavTanimla();
                            break;


                        case 8:
                            break;


                        case 9:
                            Environment.Exit(0);
                            break;


                        default:
                            Console.WriteLine("Yanlış girdi.");
                            Console.ReadKey();
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



    }
}
