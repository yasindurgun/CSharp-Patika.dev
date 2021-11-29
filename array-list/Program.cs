using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList list = new ArrayList();
            //list.Add("Ayşe");
            //list.Add(21);
            //list.Add(true);
            //list.Add('A');

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange
            Console.WriteLine("*****Add Range*****");
            //string[] colors = { "red", "black", "white" };
            List<int> numbers = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            //list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("*****Sort*****");
            //list.Sort(); //run-time da hata verir.

            //Binary Search
            Console.WriteLine("*****Binary Search*****");
            Console.WriteLine(list.BinarySearch(9));

            //Reverse
            Console.WriteLine("*****Reverse*****");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear listeyi temizler.
            list.Clear();
            Console.ReadKey();
        }
    }
}
