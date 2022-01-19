using System;
using System.Collections.Generic;
using System.Linq;

namespace phone_directory_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Directory> directories = new List<Directory>();
            MainScreen(directories);
        }

        private static void MainScreen(List<Directory> directories)
        {
            bool ısOk = true;
            int number;
            char c='n';
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("********************************************");
                Console.Write("(1) Yeni numara kaydetmek: \n");
                Console.Write("(2) Varolan numarayı silmek: \n");
                Console.Write("(3) Varolan numarayı güncelleme: \n");
                Console.Write("(4) Rehberi listelemek \n");
                Console.Write("(5) Rehberde arama yapmak \n");
                number = int.Parse(Console.ReadLine());
                if (number < 1 && number > 5)
                {
                    Console.WriteLine("Hatalı numara seçimi. Tekrar seçin.");
                    ısOk = false;
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            SaveNewNumber(directories);
                            break;
                        case 2:
                            DeleteNumber(directories);
                            break;
                        case 3:
                            UpdateNumber(directories);
                            break;
                        case 4:
                            ListDirectory(directories);
                            break;
                        case 5:
                            DeleteNumber(directories);
                            break;
                        default:
                            Console.WriteLine("Hatalı kullanım.");
                            break;
                    }

                    Console.WriteLine("\n\nBaşka bir işlem yapmak istiyor musunuz?(y/n)");
                    c = Convert.ToChar(Console.ReadLine());
                }
               

            } while (!ısOk || c =='y');
           

        }
        private static void SaveNewNumber(List<Directory> directories)
        {
            Directory directory = new Directory();

            Console.Write("Lütfen isim giriniz: ");
            directory.Name = Console.ReadLine().Trim();

            Console.Write("\nLütfen soyisim giriniz: ");
            directory.Surname = Console.ReadLine().Trim();

            Console.Write("\nLütfen telefon numarası giriniz: ");
            directory.PhoneNumber = Console.ReadLine().Trim();

            directories.Add(directory);
        }
        private static void DeleteNumber(List<Directory> directories)
        {
            bool Ok = true;
            while (Ok)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string person = Console.ReadLine().Trim().ToLower();

                var obj = directories.FirstOrDefault(x => x.Name.ToLower() == person || x.Surname.ToLower() == person);
                if (obj != null)
                {
                    Console.Write($"{obj.Name} {obj.Surname} isimli kişi rehberden silinmek üzere, onaylıyor musunuz?(y/n)");
                    char situation = Convert.ToChar(Console.ReadLine());
                    if (situation == 'y')
                    {
                        directories.Remove(obj);
                        Console.WriteLine("Kişi rehberinizden silindi");
                        directories.Remove(obj);
                        Ok = false;
                    } 
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için: (1) ");
                    Console.WriteLine("*Yeniden denemek için: (2)");
                    Console.WriteLine("= ");
                    char number = Convert.ToChar(Console.ReadLine());
                    if (number == '1')
                    {
                        Ok = false;
                    }
                    else if (number == '2')
                    {
                        Ok = true;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı kullanım");
                        Ok = false;
                    }
                }
            } 
        }
        private static void UpdateNumber(List<Directory> directories)
        {
            Directory d = new Directory();
            bool Ok = true;
            while (Ok)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                string person = Console.ReadLine().Trim().ToLower();

                var obj = directories.FirstOrDefault(x => x.Name.ToLower() == person || x.Surname.ToLower() == person);
                if (obj != null)
                {
                    Console.Write($"{obj.Name} {obj.Surname} isimli kişi güncellenmek üzere, onaylıyor musunuz?(y/n)");
                    char situation = Convert.ToChar(Console.ReadLine());
                    if (situation == 'y')
                    {
                        Console.WriteLine("Yeni numara: ");
                        d.PhoneNumber = Console.ReadLine().Trim();
                        obj.PhoneNumber = d.PhoneNumber;
                        Ok = false;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için: (1) ");
                    Console.WriteLine("*Yeniden denemek için: (2)");
                    Console.WriteLine("= ");
                    char number = Convert.ToChar(Console.ReadLine());
                    if (number == '1')
                    {
                        Ok = false;
                    }
                    else if (number == '2')
                    {
                        Ok = true;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı kullanım");
                        Ok = false;
                    }
                }
            }

        }
        private static void ListDirectory(List<Directory> directories)
        {
            Console.WriteLine("\n\nTelefon Rehberi");
            Console.WriteLine("***************");

            foreach (var item in directories)
            {
                Console.Write("İsim: "+item.Name);
                Console.Write("\nSoyisim: "+item.Surname);
                Console.Write("\nNumara: "+item.PhoneNumber);
            }
        }
    }
}
