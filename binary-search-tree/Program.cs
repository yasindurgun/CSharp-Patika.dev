using System;

namespace binary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             [7, 5, 1, 8, 3, 6, 0, 9, 4, 2] 


//  root un sağında kendisinden büyükler solunda kendisinden küçükler yer alır.

     7   //root a ilk eleman yerleştirilir, dizide kendisinden sonra gelen eleman 5. 5 ile kıyaslama yapılır 5 7 den büyük mü küçük mü 

     7
    5       //küçük olduğundan soluna konulur.sırada 1 vardır 1 kıyaslaması yapılır
   1       //7 den küçük sola, 5ten küçük o yüzden 5in soluna konur. sırada 8 vardır
    

      7   // 8  7 den büyük oldğu için sağına konur.
     5  8   // sıradaki eleaman 3. 3 için kıyaslamalar yapılır
    1
     3   // 3 --> 7 den küçük 5 ten küçük ama 1 den büyük bu yüzden 1 in sağına konur. sıradaki eleman 6 için kıyaslama başlar.



         7       // 6 --> 7 den küçük ama 5 ten büyük o yüzden 5 in sağına konur  . 0 için kıyaslama başlar sonra. 1 den küçük olduğundan 1 in soluna konur
     5      8   
   1   6
 0  3



         7       // 9 için 8 den büyük olduğundan sağına gelir. 4,3 ten büyük sağına. 2 3 ten küçük soluna
     5      8
   1    6       9
 0   3
    2    4

             */
        }
    }
}
