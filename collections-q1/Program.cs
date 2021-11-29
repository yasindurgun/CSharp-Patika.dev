using System;
using System.Collections;

namespace collections_q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input;
            int number;
            ArrayList primes = new ArrayList();
            ArrayList notPrimes = new ArrayList();
            int primeTotal=0, primeAverage=0, nonPrimeTotal=0, nonPrimeAverage=0;
            bool k = true;
            while (count < 20)
            {
                Console.Write("Bir sayı giriniz: ");
                input = Console.ReadLine();
                k = true;
                foreach (var item in input)
                {
                    if (char.IsLetter(item))
                    {
                        Console.WriteLine("Metinsel bir ifade ya da karakter giremezsiniz.");
                        k = false;
                    }
                }
                if (k)
                {
                    if (Convert.ToInt32(input) < 0)
                    {
                        Console.WriteLine("Negatif bir değer giremezsiniz.");
                    }
                    else
                    {
                        number = int.Parse(input);
                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                notPrimes.Add(number);
                                break;
                            }
                            else
                            {
                                primes.Add(number);
                                break;
                            }
                        }
                        count++;
                    }
                }
            }

            primes.Sort();
            notPrimes.Sort();
            Console.WriteLine("\n***** Prime Numbers *****");
            for (int i = primes.Count - 1; i >= 0; i--)
            {
                primeTotal += Convert.ToInt32(primes[i]);
                Console.Write(primes[i] + "\t");
            }
            primeAverage = primeTotal / primes.Count;
            Console.WriteLine("\nTotal: "+primeTotal+"\nAverage: "+primeAverage);

            Console.WriteLine("\n***** Non-Prime Numbers *****");
            for (int i = notPrimes.Count - 1; i >= 0; i--)
            {
                nonPrimeTotal += Convert.ToInt32(notPrimes[i]);
                Console.Write(notPrimes[i] + "\t");
            }
            nonPrimeAverage = nonPrimeTotal / notPrimes.Count;
            Console.WriteLine("\nTotal: " + nonPrimeTotal + "\nAverage: " + nonPrimeAverage);
            Console.ReadKey();
        }
    }
}
