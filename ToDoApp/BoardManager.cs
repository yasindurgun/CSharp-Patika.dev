using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class BoardManager
    {

        public void ListCard(List<Card> TODO, List<Card> INPROGRESS, List<Card> DONE)
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("****************************");
            if (TODO != null)
            {
                foreach (var item in TODO)
                {
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~");
            }

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("****************************");
            if (INPROGRESS != null)
            {
                foreach (var item in INPROGRESS)
                {
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~");
            }


            Console.WriteLine("DONE Line");
            Console.WriteLine("****************************");
            if (DONE != null)
            {
                foreach (var item in DONE)
                {
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    Console.WriteLine("-");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~");
            }
        }
        public void AddCard(List<Card> TODO, List<Members> kisiler)
        {
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz: ");
            string icerik = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):");
            int boyut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kişi Giriniz: ");
            string kisi = Console.ReadLine();

            if (boyut > 0 && boyut <= 5)
            {
                TODO.Add(new Card(baslik, icerik, kisi, (Card.Buyukluk)boyut));

            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }
        }
        public void DeleteCard(List<Card> TODO, List<Card> INPROGRESS, List<Card> DONE)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            List<Card> temp = new List<Card>();
            temp.AddRange(TODO);
            temp.AddRange(INPROGRESS);
            temp.AddRange(DONE);
            int count = 0;
            foreach (var item in temp)
            {
                if (item.Baslik == baslik)
                {
                    count++;
                    TODO.Remove(item);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("Silme işlemi sona ermiştir.");
                }
                else
                {
                    DeleteCard(TODO, INPROGRESS, DONE);
                }

            }
        }
        public void ChangeCard(List<Card> TODO, List<Card> INPROGRESS, List<Card> DONE)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            List<Card> temp = new List<Card>();
            temp.AddRange(TODO);
            temp.AddRange(INPROGRESS);
            temp.AddRange(DONE);
            int count = 0;
            string line = "";
            foreach (var item in temp)
            {
                if (item.Baslik == baslik)
                {
                    count++;
                    Console.WriteLine("Bulunan Kart Bilgileri: ");
                    Console.WriteLine("******************************");
                    Console.WriteLine("Başlık        : " + item.Baslik);
                    Console.WriteLine("İçerik        : " + item.Icerik);
                    Console.WriteLine("Atanan Kişi   : " + item.AtananKisi);
                    Console.WriteLine("Büyüklük      : " + item.Boyut);
                    foreach (var item1 in TODO)
                    {
                        if (baslik == item1.Baslik)
                        {
                            line = "TODO";
                            Console.WriteLine("Line          : " + line);
                        }
                    }

                    foreach (var item1 in INPROGRESS)
                    {
                        if (baslik == item1.Baslik)
                        {
                            line = "IN PROGRESS";
                            Console.WriteLine("Line          : " + line);
                        }
                    }

                    foreach (var item1 in DONE)
                    {
                        if (baslik == item1.Baslik)
                        {
                            line = "DONE";
                            Console.WriteLine("Line          : " + line);
                        }
                    }

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int chooseLine = Convert.ToInt32(Console.ReadLine());
                    if (chooseLine == 1)
                    {
                        for (int i = 0; i < DONE.Count; i++)
                        {
                            if (DONE[i] == item)
                            {
                                DONE.Remove(item);
                            }
                        }

                        for (int i = 0; i < INPROGRESS.Count; i++)
                        {
                            if (INPROGRESS[i] == item)
                            {
                                INPROGRESS.Remove(item);
                            }
                        }
                        TODO.Add(item);
                    }
                    else if (chooseLine == 2)
                    {
                        for (int i = 0; i < TODO.Count; i++)
                        {
                            if (TODO[i] == item)
                            {
                                TODO.Remove(item);
                            }
                        }

                        for (int i = 0; i < DONE.Count; i++)
                        {
                            if (DONE[i] == item)
                            {
                                DONE.Remove(item);
                            }
                        }
                        INPROGRESS.Add(item);
                    }
                    else
                    {
                        for (int i = 0; i < TODO.Count; i++)
                        {
                            if (TODO[i] == item)
                            {
                                TODO.Remove(item);
                            }
                        }

                        for (int i = 0; i < INPROGRESS.Count; i++)
                        {
                            if (INPROGRESS[i] == item)
                            {
                                INPROGRESS.Remove(item);
                            }
                        }
                        DONE.Add(item);
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için: (2)");
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 1)
                {
                    Console.WriteLine("Silme işlemi sona ermiştir.");
                }
                else
                {
                    ChangeCard(TODO, INPROGRESS, DONE);
                }

            }
        }
    }
}