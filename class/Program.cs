using System;

namespace classİntro
{
    class Program
{
    static void Main(string[] args)
    {
        kurs kurs1 = new kurs();
        kurs1.kursAdi = "hey";
        kurs1.egitmen = "yurda";
        kurs1.izlenmeOrani = 68;

        kurs kurs2 = new kurs();
        kurs2.kursAdi = "c++";
        kurs2.egitmen = "yurdagul";
        kurs2.izlenmeOrani = 69;

        kurs kurs3 = new kurs();
        kurs3.kursAdi = "python";
        kurs3.egitmen = "ilker";
        kurs3.izlenmeOrani = 65;


            //  Console.WriteLine(kurs1.kursAdi + " " + kurs1.egitmen + " " + kurs1.izlenmeOrani);
            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3};
            foreach (var iyed in kurslar)
            {
                Console.WriteLine(iyed.kursAdi);
            }
        
        
        }
}
class kurs
{
    public string kursAdi { get; set; }
    public string egitmen { get; set; }

    public int izlenmeOrani { get; set; }
}
}
