using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Card
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyukluk Boyut { get; set; }

        public enum Buyukluk
        {
            XS,
            S,
            M,
            L,
            XL
        }

        public Card(string Baslik, string Icerik, string AtananKisi, Buyukluk Boyut)
        {
            this.Baslik = Baslik;
            this.Icerik = Icerik;
            this.AtananKisi = AtananKisi;
            this.Boyut = Boyut;
        }
    }
}