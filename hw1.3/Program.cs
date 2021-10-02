using System;

namespace hw1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Pozitif bir sayı girin: ");
                n = int.Parse(Console.ReadLine());
            } while (n<0);
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Kelime girin: ");
                arr[i] = Console.ReadLine();
            }

            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
