using System;

namespace collections_q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, countForMax=0, countForMin=0;
            string input;
            int number;
            int temp;
            int[] maxs = new int[3];
            int[] mins = new int[3];
            int[] numbers = new int[10];
            bool k = true;
            while (count < 10)
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
                        numbers[count] = number;
                        count++;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            
            for (int i = 0; i < 3; i++)
            {
                maxs[i] = numbers[countForMax++];
                for (int j = 0; j < 3; j++)
                {
                    for (int t = j+1; t < 3; t++)
                    {
                        if (maxs[j] == maxs[t] && (maxs[j] !=0 && maxs[t] !=0))
                        {
                            i--;
                        }
                    }
                }
            }

            countForMin = numbers.Length - 1;
            for (int i = numbers.Length-1; i > numbers.Length-4; i--)
            {
                mins[numbers.Length-1-i] = numbers[countForMin--];
                for (int j = 0; j < 3; j++)
                {
                    for (int t = j + 1; t < 3; t++)
                    {
                        if (mins[j] == mins[t] && (mins[j] != 0 && mins[t] != 0))
                        {
                            i++;
                        }
                    }
                }
            }


            Console.WriteLine("***** Numbers *****");
            foreach (var item in numbers)
            {
                Console.Write(item+"\t");
            }

            int maxTotal = 0;
            double maxAverage = 0;
            Console.WriteLine("\n***** Max Numbers *****");
            foreach (var item in maxs)
            {
                maxTotal += item;
                Console.Write(item+"\t");
            }
            maxAverage = maxTotal / maxs.Length;
            Console.WriteLine("\nMax Total: "+maxTotal);
            Console.WriteLine("Max Average: "+maxAverage);

            int minTotal = 0;
            double minAverage = 0;
            Console.Write("\n***** Min Numbers *****\n");
            foreach (var item in mins)
            {
                minTotal += item;
                Console.Write(item+"\t");
            }
            minAverage = minTotal / mins.Length;
            Console.WriteLine("\nMin Total: " + minTotal);
            Console.WriteLine("Min Average: " + minAverage);

            Console.ReadKey();
        }
    }
}
