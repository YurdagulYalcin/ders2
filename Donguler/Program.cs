using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazılım geliştirici yetiştirme kampı","programlamaya başlangıç için temel kamp","java","python"};
            
            for (int i =0 ; i < kurslar.Length; i=i+1 )
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (var kurs in kurslar) // forech yapısı dizi temelli yapıları dönmeye yarıyor
            {
                Console.WriteLine(kurs); //forech içindeki kurs kelimesi ekrana yazdırmak için kullanılır beby. Kurs burda takma isim, xyz falan da yazabilirisn
            }
        }
    }
}
