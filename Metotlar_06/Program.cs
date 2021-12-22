using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_06
{
    class Program
    {
        // Bizim Insan adında bir classımız. Bu sınıfın Konusmak() methodu adını söylesin 

        static void Main(string[] args)
        {

            //Insan.Konusmak(); //Static method kullanımı

            Insan i = new Insan();
            i.Konusmak();


            Console.ReadLine();
        }
    }

    class Insan
    {
        //public static void Konusmak()
        //{
        //    Console.WriteLine("Ben bir insanım");
        //}

        public void Konusmak()
        {
            Console.WriteLine("Ben bir insanım");
        }
    }
}
