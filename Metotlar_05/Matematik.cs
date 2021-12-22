using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_05
{
    //*** ERİŞİM BELİRTECLERİ : public,private,protected,internal
    //public : proje içerisinde genel erişime açık hale getirir. 
    //private: kendi class'ı içeriisnde erişime açık hale getirir. Default olarak (bir şey yazılmazsa) private tanımlı olur.

    class Matematik
    {
        public static void DortIslem(int sayi1, int sayi2, string secim)
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

            Console.WriteLine("Sonuç:" + sonuc);
        }

        void Yaz()
        {
            Console.WriteLine("Altan Emre");
        }

        public void GenelYaz()
        {
            Yaz();
        }
    }

}
