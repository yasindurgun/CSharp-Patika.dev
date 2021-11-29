using System;
using System.Collections.Generic;

namespace collections_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = new List<char>();
            List<char> vowels = new List<char>{ 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };

            Console.Write("Bir cümle yazınız:");
            string sentence = Console.ReadLine();

            foreach (var item in sentence)
            {
                for (int i = 0; i < vowels.Count-1; i++)
                {
                    if (item == vowels[i])
                    {
                        chars.Add(item);
                    }
                }
            }

            foreach (var item in chars)
            {
                Console.Write(item+"\t");
            }
            Console.ReadKey();
        }
    }
}
