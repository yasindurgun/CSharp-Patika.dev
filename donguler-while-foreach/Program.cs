using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character + " ");
                character++;
            }

            Console.WriteLine("***** Foreach *****");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
