using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // DÖVİZ BÜROSU: Müşteri elindeki dolar'ı euro çevirmek istiyor ama çalışan dolar/euro endeksini bilmiyor.
            // Bildiği şey dolar kaç tl olduğu ve euro kaç tl olduğu 


            double tl = DolarToTL();
            //Console.WriteLine("Lira Karşılığı:"+tl);
            EuroToTL(tl);
            Console.ReadLine();


        }

        static double DolarToTL()
        {
            Console.WriteLine("Kaç Dolar Bozulacak?");
            int dolar = Convert.ToInt32(Console.ReadLine());
            double lira = dolar * 16.8;
            return lira;
        }

        static void EuroToTL(double lira)
        {
            double euro = lira / 20.45;
            Console.WriteLine("Euro:"+euro);
        }
    }
}
