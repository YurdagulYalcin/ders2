using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {//naming convetion(isimlendirme kuralları
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi" + urun.Adi);
        }
        public void Ekle2(string urunAdi,string Aciklama,double fiyati,int stokAdedi)
        {
            Console.WriteLine("sepete eklendi " + urunAdi);
        }
    }
}
