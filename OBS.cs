using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class OBS
    {

        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static List<Ders> dersler = new List<Ders>();
        public static List<Sinav> sinavlar = new List<Sinav>();

        public OBS()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            List<Ders> dersler = new List<Ders>();
            List<Sinav> sinavlar = new List<Sinav>();
        }


        public static void debug_Tanim_ogr()
        {
            /*
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Ogrenci debug = new Ogrenci();
                debug.TCKNO = Convert.ToString(rand.Next(100000000, 999999999));
                debug.AdSoyad= "Ali Deneme";
                debug.Bolum = "BP";
                debug.OgrenciNo = Convert.ToString(rand.Next(100000000, 999999999));
                Console.WriteLine("Debug ogrenci tanım yapıldı.");
                OgrenciEkle(debug);
            }
            */
            Ogrenci debug = new Ogrenci();
            debug.TCKNO = "11111111111";
            debug.AdSoyad = "Cevdet Baran";
            debug.Bolum = "BP-1";
            debug.OgrenciNo = "210910009";
            Console.WriteLine("Debug ogrenci tanım yapıldı.");
            OgrenciEkle(debug);
        }
        public static void debug_Tanim_ders()
        {
            Ders debug = new Ders();
            debug.Ad = "NYP";
            debug.Kod = "MYP122";
            Console.WriteLine("Debug ders tanım yapıldı.");
            YeniDersEkle(debug);
        }
        public static void OgrenciyeDersEkle()
        {
            try
            {
                Console.WriteLine("Ders kodu giriniz: ");
                string DersKod = Console.ReadLine();
                Console.WriteLine("Ogrenci kodu giriniz: ");
                string OgrenciNo = Console.ReadLine();
                Ders ders = Ders_Service.DersBul(DersKod);
                Ogrenci ogrenci = Ogrenci_Service.OgrenciBul(OgrenciNo);

                if (ogrenci != null && ders != null)
                {
                    OBS.DersEkle(ders, ogrenci);
                    Console.WriteLine("Ders eklendi.");
                }

            }
            catch (Exception E)
            {
                Console.WriteLine("Yanlış girdi.");
            }
        }
        public static void OgrenciyeDersEkle(string OgrenciNo)
        {
            try
            {
                Console.WriteLine("Ders kodu giriniz: ");
                string DersKod = Console.ReadLine();
                Ders ders = Ders_Service.DersBul(DersKod);
                Ogrenci ogrenci = Ogrenci_Service.OgrenciBul(OgrenciNo);

                if (ogrenci != null && ders != null)
                {
                    OBS.DersEkle(ders, ogrenci);
                }

            }
            catch (Exception E)
            {
                Console.WriteLine("Yanlış girdi.");
                Console.WriteLine(E);
            }
        }
        public static void OgrencidenDersSil(string OgrenciNo)
        {
            try
            {
                Console.WriteLine("Silmek istediğiniz dersin kodunu giriniz: ");
                string DersKod = Console.ReadLine();
                Ders ders = Ders_Service.DersBul(DersKod);
                Ogrenci ogrenci = Ogrenci_Service.OgrenciBul(OgrenciNo);

                if (ogrenci != null && ders != null)
                {
                    OBS.DersSil(ders, ogrenci);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Yanlış girdi.");
            }
        }
        public void DersleriYazdir()
        {
            dersler.ForEach(i => Console.WriteLine(i));
        }

        public static Ders YeniDersTanımla()
        {
            Console.Clear();
            Ders ders = new Ders();
            Console.WriteLine("Dersin adını giriniz: ");
            ders.Ad = Console.ReadLine();
            Console.WriteLine("Dersin kodunu giriniz: ");
            ders.Kod = Console.ReadLine();
            Console.WriteLine("Ders Tanımlandı.");
            YeniDersEkle(ders);
            return ders;
        }

        public static bool DersKontrol(Ders ders, Ogrenci ogrenci)
        {
            if (ogrenci.AldigiDersler.Contains(ders))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void YeniDersEkle(Ders ders)
        {
            dersler.Add(ders);
        }
        public static void DersEkle(Ders ders, Ogrenci ogrenci)
        {
            if (dersler.Contains(ders))
            {
                if (DersKontrol(ders, ogrenci))
                {
                    Console.WriteLine("Bu ders zaten alınmış.");
                }
                else
                {
                    if (ogrenci.DersSayisi < 8)
                    {
                        ogrenci.AldigiDersler.Add(ders);
                        ogrenci.DersSayisi++;
                        Console.WriteLine("Ders eklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Öğrencinin ders sayısı 8'e ulaşmış.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Eklenmek istenen ders bulunamadı.");
            }
        }
        public static void OgrenciSil(Ogrenci ogrenci)
        {
            Console.WriteLine("Öğrenciyi silmeyi onaylıyorsanız EVET yazınız:");
            string s = Console.ReadLine();

            if (s == "EVET")
            {
                if (ogrenciler.Contains(ogrenci))
                {
                    ogrenciler.Remove(ogrenci);
                    Console.WriteLine("Ogrenci silindi.");
                }
                else
                {
                    Console.WriteLine("Silmek istenen ogrenci bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Silme işlemi iptal edildi.");
            }
        }
        public static void DersSil(Ders ders, Ogrenci ogrenci)
        {
            if (dersler.Contains(ders))
            {
                if (DersKontrol(ders, ogrenci))
                {
                    ogrenci.AldigiDersler.Remove(ders);
                    ogrenci.DersSayisi--;
                    Console.WriteLine("Ders silindi.");
                }
                else
                {
                    Console.WriteLine("Bu ders zaten alınmamış.");
                }
            }
            else
            {
                Console.WriteLine("Silmek istenen ders bulunamadı.");
            }
        }
        public static Ogrenci OgrenciTanimla()
        {
            Console.Clear();
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Öğrencinin adı ve soyadını giriniz: ");
            ogrenci.AdSoyad = Console.ReadLine();
            Console.WriteLine("Öğrencinin Numarasını giriniz: ");
            ogrenci.OgrenciNo = Console.ReadLine();
            Console.WriteLine("Öğrencinin bölümünü giriniz: ");
            ogrenci.Bolum = Console.ReadLine();
            Console.WriteLine("Öğrencinin TCKNO'sunu giriniz: ");
            ogrenci.TCKNO = Console.ReadLine();
            Console.WriteLine("Öğrenci tanımlandı.");
            OgrenciEkle(ogrenci);
            return ogrenci;
        }
        public static void OgrenciEkle(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
        }
        public static void OgrencilerListe()
        {

            ogrenciler.ForEach(i => Console.WriteLine(i));

        }
        public Ders DersTanımla()
        {
            Ders ders = new Ders();
            Console.WriteLine("Dersin adını giriniz: ");
            ders.Ad = Console.ReadLine();
            Console.WriteLine("Dersin kodunu giriniz: ");
            ders.Kod = Console.ReadLine();
            Console.WriteLine("Ders Tanımlandı.");
            return ders;
        }




    }
}
