using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // string tipten int veri tipine dönüştürme
            //int a = 5;
            //Byte b = (byte)a;
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(b);
            
            
            //yöntem 1
            string sayi1 = "3";
            string sayi2 = "65";
            int c = int.Parse(sayi1);
            int d = int.Parse(sayi2);
            Console.WriteLine(c + d);
            //yöntem 2
            int f = Convert.ToInt32(c);
            int e = Convert.ToInt32(d);
            Console.WriteLine(f + e);

            //int veri tipini stringe dönüştürme
            int sayi3 = 5;
            int sayi4 = 5;
            string a = sayi3.ToString();
            string b = sayi3.ToString();
            Console.WriteLine(a + b);

            //kullanıvıdan alınan string veri tipini ing yapma
            Console.WriteLine("yaşınız");
            string yas = string.Empty;
            yas = Console.ReadLine();

            Console.WriteLine("yaşınız");
            string yas2 = string.Empty;
            yas2 = Console.ReadLine();
            int z = Convert.ToInt32(yas2);

            int y = Convert.ToInt32(yas);
            Console.WriteLine(y.GetType());
            Console.WriteLine(y+z);


            Console.ReadLine();
        }
    }
}
