using System;

namespace hw1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, sayi;
            do
            {
                Console.Write("Pozitif bir sayı girin: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            do
            {
                Console.Write("Pozitif bir sayı girin: ");
                m = Convert.ToInt32(Console.ReadLine());
            } while (m < 0);

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Sayı: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if(sayi == m || sayi % m == 0)
                {
                    arr[i] = sayi;
                }
            }
            foreach (var item in arr)
            {
                if (item == 0) continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
