using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Sunday);

            int temparature = 19;
            if (temparature <= (int)Weather.Normal)
            {
                Console.WriteLine("Cold");
            }
            else if (temparature >= (int)Weather.TooHot)
            {
                Console.WriteLine("TooHot");
            }
            Console.ReadKey();
        }
    }

    enum Days
    {
        Monday=1,
        Tuesday,
        Wednasday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Cold=5,
        Normal=20,
        Hot=25,
        TooHot=30

    }
}
