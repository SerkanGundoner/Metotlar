using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //OVERLOAD => Aşırı Yüklenme
            // aynı isimde farklı görevler,işlemler yapan metotlara overload method denir.

            Toplam(1,2,3);


        }

        static void Toplam()
        {
            Console.WriteLine("1. sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Toplam:"+(s1+s2));
        }

        static void Toplam(int s1,int s2)
        {
            Console.WriteLine("2.Toplam:" + (s1 + s2));
        }

        static void Toplam(int s1, int s2,int s3)
        {
            Console.WriteLine("3.Toplam:" + (s1 + s2+s3));
        }

    }
}
