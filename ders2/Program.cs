using System;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
         {
            string kategoriEtiketi = "kategori"; //type safety=tip güvenliği   
            Console.WriteLine(kategoriEtiketi);
            bool sistemeGirisYapmisMi = true;
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("kullanıcı Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");     
            }
        }
    }
}
 