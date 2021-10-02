using System;

namespace hw1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            int countOfLetters = 0;
            Console.Write("Bir cümle yazınız: ");
            sentence = Console.ReadLine();

            string[] word = sentence.Split(" ");
            Console.WriteLine("Bu cümle " +word.Length + " kelimeden oluşmaktadır.");

            foreach (var item in word)
            {
                countOfLetters += item.Length;
            }

            Console.WriteLine("Bu cümle " + countOfLetters + " harften oluşmaktadır.");
            Console.ReadKey();
        }
    }
}
