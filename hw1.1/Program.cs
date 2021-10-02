using System;

namespace hw1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k;
            do
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("Pozitif bir sayı giriniz: ");
                    k = Convert.ToInt32(Console.ReadLine());
                    if(k % 2 == 0)
                    {
                        arr[i] = k;
                    }
                    
                } while (k < 0);
            }

            foreach (var item in arr)
            {
                if(item == 0)
                {
                    continue;
                }
                    Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
