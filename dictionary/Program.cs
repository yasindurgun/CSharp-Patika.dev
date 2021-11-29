using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //systems.collections.generic
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(10,"Ayşe Yılmaz");
            users.Add(12,"Ahmet Yılmaz");
            users.Add(18,"Deniz Arda");
            users.Add(20,"Özcan Coşar");

            //Dizinin elemanlarına erişim.
            Console.WriteLine("***** Elamanlara Erişim *****");
            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine(users.ContainsKey(20));
            Console.WriteLine(users.ContainsValue("Ali"));

            //Remove
            users.Remove(12);

            //Keys
            //Values
            Console.ReadKey();
        }
    }
}
