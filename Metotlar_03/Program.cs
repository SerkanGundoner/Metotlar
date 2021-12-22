using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 ürün fiyatı alalım ve pahalı olan ürüne %30 indirim uygulayan metot.
            // ve 3.ürünü almak ister misiniz? E-> 3.ürüne de %50 indirim uygulayarak ekrana toplam ödemeyi yazdıralım. 

            //1.Yol
            //Indirim();

            //2.Yol
            Console.WriteLine("1.Ürün Fiyatı:");
            double f1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Ürün Fiyatı:");
            double f2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("3. Ürün ister misiniz?(E/H)");
            string cevap = Console.ReadLine().ToLower();

            if (cevap == "h")
                Indirim2(f1, f2);
            else if(cevap=="e")
                Indirim3(f1, f2);


            Console.ReadLine();
        }

        #region 1.Yol
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double f1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Ürün Fiyatı:");
            double f2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3.ürün de %50 indirim var. İster misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                Console.WriteLine("3.Ürün Fiyatı:");
                double f3 = Convert.ToDouble(Console.ReadLine());
                if (f1 > f2)
                {
                    f1 = f1 * 0.70;
                }
                else
                {
                    f2 = f2 * 0.70;
                }

                double toplam = f1 + f2 + (f3 * 0.50);
                Console.WriteLine("Ödeme:" + toplam);
            }
            else
            {
                if (f1 > f2)
                {
                    double toplam = (f1 * 0.70) + f2;
                    Console.WriteLine("Ödeme:" + toplam);
                }
                else
                {
                    double toplam = (f2 * 0.70) + f1;
                    Console.WriteLine("Ödeme:" + toplam);
                }
            }
        }
        #endregion

        static void Indirim2(double f1, double f2)
        {
           

            if (f1 > f2)
            {
                double toplam = (f1 * 0.70) + f2;
                Console.WriteLine("Ödeme:" + toplam);
            }
            else
            {
                double toplam = (f2 * 0.70) + f1;
                Console.WriteLine("Ödeme:" + toplam);
            }
        }

        static void Indirim3(double f1,double f2)
        {
            Console.WriteLine("3.ürün fiyatı:");
            double f3 = Convert.ToDouble(Console.ReadLine());
            if (f1 > f2)
            {
                double toplam = (f1 * 0.70) + f2+(f3/2);
                Console.WriteLine("Ödeme:" + toplam);
            }
            else
            {
                double toplam = (f2 * 0.70) + f1+(f3/2);
                Console.WriteLine("Ödeme:" + toplam);
            }
        }
    }
}
