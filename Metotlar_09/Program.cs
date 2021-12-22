using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5 };
            Yaz(sayilar);

            int[] alar = new int[5];
            int a = 5;
            Ekle(alar, a);
            Console.ReadKey();

        }

        static void Yaz(int[] rakamlar)
        {
            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine(rakamlar[i]);
            }
        }

        static void Ekle(int[] rakamlar,int s)
        {
            rakamlar[0] = s;
        }
    }
}
