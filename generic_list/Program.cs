using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object türündendir.

            List<int> numberList = new List<int>();

            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(55);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Black");
            colorList.Add("White");

            Console.WriteLine(numberList.Count); //eleman sayısını verir.

            foreach (var item in colorList)
            {
                Console.WriteLine(item);
            }

            numberList.ForEach(number => Console.WriteLine(number));

            numberList.Remove(55); //girilen değeri listeden çıkarır.
            colorList.RemoveAt(1); //verilen indekse göre eleman çıkarır.

            //Liste içerisinde arama
            if (numberList.Contains(23))
            {
                Console.WriteLine("Bulundu.");
            }

            //eleman ile indexe erişme
            Console.WriteLine(colorList.BinarySearch("White"));

            //Diziyi listeye çevirme
            string[] animals = { "Cat", "Dog", "Bird" };

            List<string> animalsList = new List<string>(animals);

            animalsList.Clear(); //tüm listeyi temizler.

            //list içerisinde liste tutmak
            List<User> users = new List<User>();
            User user1 = new User();
            user1.Name = "Ahmet";
            user1.Surname = "Kara";
            user1.Age = 26;

            User user2 = new User();
            user2.Name = "Özcan";
            user2.Surname = "Çalışkan";
            user2.Age = 26;

            users.Add(user1);
            users.Add(user2);

            foreach (var item in users)
            {
                Console.WriteLine(item.Name+" "+item.Surname+" "+item.Age);
            }

            Console.ReadKey();
        }
    }

    public class User
    {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
