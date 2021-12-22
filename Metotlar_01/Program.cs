using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 Sayı alıp toplayarak ekrana yazdıran method?

            //ToplamParametresiz();

            //ToplamParametreli(11, 12);



            Console.WriteLine("1. sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            ToplamParametreli(s1,s2);
            Console.ReadLine();
        }

        // static: Bir yol(instance) almadan direk kullanılabilir yapı demektir ve static tanımlı yapıların içinde (static void Main(string[] args)) static yapılar(metotlar) kullanılması gereklidir.

        //INSTANCE(ÖRNEKLEM)
        // Tanımlı bir classtan bir örnek alma işlemidir. Bizim arkaplanda tanımlı bir RANDOM classımız var. Bunun içindeki yapıları kullanmak için bir instance alırız. Random r = new Random(); 
                
        
        static void ToplamParametresiz()
        {
            Console.WriteLine("1. sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam:" + (s1 + s2));
        }

        static void ToplamParametreli(int sayi1,int sayi2)
        {
            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }

        static void ToplamParametreli(int sayi1, int sayi2,int sayi3)
        {
            Console.WriteLine("Toplam:" + (sayi1 + sayi2 + sayi3));
        }
    }
}
