using System;
using System.Collections.Generic;
using System.Text;

namespace örnek_OBS_sistemi
{
    class MenuManager
    {
        public void menuPrinter()
        {
            Console.WriteLine("         Menu        ");
            Console.WriteLine("---------------------");
            Console.WriteLine("1-> Öğrenci Tanımla");
            Console.WriteLine("2-> Ders Tanımla");
            Console.WriteLine("3-> Öğrenciye Ders Ekle");
            Console.WriteLine("4-> Öğrencileri Listele");
            Console.WriteLine("5-> Dersleri Listele");
            Console.WriteLine("6-> Bir Öğrencinin Bilgilerini Gör");
            Console.WriteLine("7-> Sınav Tanımla");
            Console.WriteLine("9-> Programı Sonlandır");
        }

        public void sinav_menuPrinter()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("1) Ders Ekle  2) Ders Sil  3) Ders Göster " +
                "4) Öğrenci Sil  5) Geri Dön");
        }


    }
}
