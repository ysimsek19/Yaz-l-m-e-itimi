using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digDortgenGenislikHesab
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, b,h,t, alan, cevre, sec;
            Console.WriteLine("1-KARE");
            Console.WriteLine("2-DİKDÖRTGEN");
            Console.WriteLine("3-DAİRE");
            Console.WriteLine("4-UÇGEN");
            Console.WriteLine("----------------------");
            Console.Write("SEÇİMİNİZ:");
            sec = Convert.ToDouble(Console.ReadLine());
            if (sec == 1)
            {
                Console.Write("Karenin Bir Kenar Uzunluğunu Girin:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Karenin Alanı:" + a * a);
                Console.WriteLine("Karenin Çevresi:" + 4 * a);
            }
            if (sec == 2)
            {
                Console.Write("Dikdörtgenin Kısa Kenar Uzunluğunu Girin:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Dikdörtgenin Uzun Kenar Uzunluğunu Girin:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin Alanı:" + a * b);
                Console.WriteLine("Dikdörtgenin Çevresi:" + 2 * (a + b));
            }
            if (sec == 3)

            {
                Console.Write("Dairenin Yarıçap Uzunluğunu Girin:");
                r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dairenin Alanı:" + (3.14 * r * r));
                Console.WriteLine("Dairenin Çevresi:" + (2 * 3.14 * r));
            }
            if (sec==4)
            {
                Console.Write("Uçgen yüksekliğini giriniz");
                h = Convert.ToDouble(Console.ReadLine());
                Console.Write("Uçgen taban giriniz");
                t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("üçgen alan" + (t * h) / 2);
            }
            Console.ReadKey();
            }

        }
    }

