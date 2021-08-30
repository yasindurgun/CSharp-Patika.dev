using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("İsminizi Giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soyisminizi Giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba, " + name + " " + surname);
            Console.ReadKey();
        }
    }
}
