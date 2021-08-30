using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //2 byte
            sbyte c = 5;    // 2 byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui = 4;    //4 byte

            long l = 4;     //8 byte
            ulong ul = 4;   // 8 byte

            //Reel sayilar
            float f = 5;    //4 byte
            double d = 5;   //8 byte
            decimal de = 5;  // 16 byte

            char ch = '2';  //2 byte
            string str = "merhaba"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str = "Yasin Durgun";
            string ad = "Yasin";
            string soyad = "Durgun";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama sekilleri

            int integer1 = 3;
            int integer2 = 5;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10 > 2; // true

            //Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //datetime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string dateTime3 = DateTime.Now.ToString("hh.mm");
            Console.WriteLine(dateTime3);

            Console.ReadKey();
        }
    }
}
