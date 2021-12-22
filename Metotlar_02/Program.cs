using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan ürün fiyatını parametre olarak alan ve %18 KDV sini hesaplayarak ekrana yazdıran metotu yazınız 

            //KDVHesapla(100);

            Console.WriteLine("Ürün Fiyatı:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            KDVHesapla(fiyat);
            Console.ReadLine();
        }

        static void KDVHesapla(double f)
        {
            Console.WriteLine("Ödeme:"+(f*1.18));
        }
    }
}
