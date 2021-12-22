using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_00
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ********** METOTLAR **********
             Belirli bir işlemi ilerleyen kod satırlarında veya farklı sayfalarda tekrar tekrar yazmamak için kullanılan bir yazılım yapısıdır.
            ** Metotlar '()' bu karakterlerle tanımlanır.

            Metotlar 2'ye ayrılır.
                * Değer Döndürmeyen Metotlar -- Parametreli ve Parametresiz
                * Değer Döndüren Metotlar -- Parametreli ve Parametresiz
                
            Metotlar tanımlandıktan sonra kullanılmak istendiğinde çağrılmaları gerekir.

            *** DEĞER DÖNDÜRMEYEN METOTLAR(void)
            İşlemleri yaptıktan sonra işi biter ve bir değer taşımaz.

            *** DEĞER DÖNDÜREN METOTLAR(return)
            İşlemleri yaptıktan sonra istenilen değeri geri getirir.
             

            ** DEĞER DÖNDÜRMEYEN METOT TANIMLAMA **

            erişimbelirteci void MetotAdı(varsa parametre)
            {
                metot işlemleri
            }
            
            ** METOT ÇAĞIRMA **
            
             Metotadı(varsa parametre)


            ** Parametre Nedir?
            Metot tanımlanırken dışarıdan değer gönderileceğini ve kaç tane değer gönderileceğini, hangi tipte değerler olacağını belirtme işlemidir.

            Tanımlarken verilen parametre sayısı ve veri tipleri önemlidir, isimleri önemsizdir(tanımlanan aynı isimle parametre gönderilmesi zorunlu değildir.).

             */

            Toplama();

            Console.WriteLine("1. Metot Bitti.");

            Toplama();

            Console.WriteLine("2. Metot Bitti.");

            Toplama();

            Console.WriteLine("3. Metot Bitti.");

            Console.ReadLine();
            
        }

        static void Toplama()
        {
            Console.WriteLine("1. sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam:" + (s1 + s2));
        }
    }
}
