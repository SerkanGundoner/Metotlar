using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEĞER DÖNDÜREN METOTLAR
            // metot sonucunda ortaya çıkan değer program akışında(metodu çağırdığınız satırdan sonra) kullanılacak ise DEGER DÖNDÜREN METOT kullanılır.
            //Toplam();
            //Console.WriteLine(Toplam2()); //Console.WriteLine(toplam);
            int donen = Toplam2();
            Console.WriteLine("Gelen değer"+donen);
            Console.ReadLine();
        }

        static void Toplam()
        {
            Console.WriteLine("1. sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam:" + (s1 + s2));
        }

        static int Toplam2()
        {
            Console.WriteLine("1. sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int toplam = s1 + s2;
            return toplam; //return s1+s2
        }
    }
}
