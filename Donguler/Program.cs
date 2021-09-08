using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                    ciftToplam += i;
            }
            Console.WriteLine($"Tek Toplam: {tekToplam}");
            Console.WriteLine($"Çift Toplam: {ciftToplam}");

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
