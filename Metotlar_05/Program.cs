using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan  2 sayı bir işlem alarak dört işlem gerçekleştiren bir metot yazınız.

            //Console.WriteLine("1.sayı:");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayı:");
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İşlem:+,-,*,/");
            //string islem = Console.ReadLine();

            //DortIslem(s1, s2, islem);

            // ***** CLASS'TAN ERİŞİM *****

            //Matematik.DortIslem(s1, s2, islem);

            //Matematik.GenelYaz();

            //*** Metot STATIK değilse ***

            //Matematik v = new Matematik();
            //v.GenelYaz();
            



            Console.ReadKey();
        }

        static void DortIslem(int sayi1,int sayi2,string secim)
        {
            int sonuc = 0;

            switch (secim)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 == 0)
                        sonuc = 0;
                    else
                        sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Hatalı işlem Seçimi!!!");
                    break;
            }

            Console.WriteLine("Sonuç:"+sonuc);
        }
    }
}
