using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            Console.WriteLine(time);
            if(time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın.");
            }
            else if(time >= 11 && time < 18)
            {
                Console.WriteLine("İyi Günler.");
            }
            else if (time >= 18 && time <= 23)
            {
                Console.WriteLine("İyi Akşamlar.");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            //ternary
            string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";

            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time >= 11 && time < 18 ? "İyi akşamlar" : "İyi geceler";
            Console.WriteLine(sonuc);
        }
    }
}
