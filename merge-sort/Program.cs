using System;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             [16,21,11,8,12,22] 


      16,21,11           8,12,22  dizi daha küçük parçalara ayrılır

    16,21   11         8,12     22

    16  21   11        8  12   22  birleştirme yapıılırken tek tek dizi elemanları içerisinde kıyaslama yapılır zaten en küçük yapıda olduğundan 2 li kıyaslama olur

    16,21   11            8,12   22

     11,16,21               8,12,22

             8,11,12,16,21,22   --> merge sort uygulanmış hali

     Big O notation --> O(n)

             n elemanlı dizide ki n tane eleman kıyaslanır, n eleman üzerinden işlem yapıldığından O(n) olur
             */
        }
    }
}
