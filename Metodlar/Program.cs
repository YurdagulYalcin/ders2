using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Aciklama = "yeşil elma";
            urun1.fiyati = 12;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "pijamalı";
            urun2.fiyati = 8 ;

            Urun urun3 = new Urun();
            urun3.Adi = "çilek";
            urun3.Aciklama = "silifke";
            urun3.fiyati =  22;

            Urun urun4 = new Urun();
            urun4.Adi = "erik";
            urun4.Aciklama = "yeşil erik";
            urun4.fiyati = 18;

            Urun urun5 = new Urun();
            urun5.Adi = "armut";
            urun5.Aciklama = "deveci";
            urun5.fiyati = 4 ;

            Console.WriteLine("--------metodlar------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);
            sepetManager.Ekle(urun5);



        }
    }
}
