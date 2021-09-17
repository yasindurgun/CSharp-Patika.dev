using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;

            Console.WriteLine(a+b);
            int sonuc = Topla(a,b);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

            Console.ReadKey();
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(String veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1 + deger2;
        }
    }
}
