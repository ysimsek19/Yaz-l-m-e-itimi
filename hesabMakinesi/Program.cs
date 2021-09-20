using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesabMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sonuc,islem;
            Console.WriteLine("1-TOPLA");
            Console.WriteLine("2-ÇIKAR");
            Console.WriteLine("3-ÇARP");
            Console.WriteLine("4-BÖL");
            Console.WriteLine("---------");
            Console.Write("Yapmak istediğiniz işlemi seçiniz ?");
            islem = Convert.ToInt32(Console.ReadLine());

            if (islem==1)
            {
                Console.WriteLine("Birinci Sayıyı giriniz");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı giriniz");
                b = Convert.ToDouble(Console.ReadLine());
                sonuc = a + b;
                Console.WriteLine("Toplama işleminin sonucu:" + " " + sonuc);

            }
            
            if (islem == 2)
            {
                Console.WriteLine("Birinci Sayıyı giriniz");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı giriniz");
                b = Convert.ToDouble(Console.ReadLine());
                sonuc = a - b;
                Console.WriteLine("Çıkartma işleminin sonucu:" + " " + sonuc);

            }
            if (islem == 3)
            {
                Console.WriteLine("Birinci Sayıyı giriniz");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı giriniz");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Çarpma işleminin sonucu:" + " " + a * b);

            }
            if (islem == 4)
            {
                Console.WriteLine("Birinci Sayıyı giriniz");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İkinci Sayıyı giriniz");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Bölme işleminin sonucu:" + " " + a / b);

            }
            else
            {
                Console.WriteLine("Lütfen 1 ile 4 arası bir sayı giriniz.");
            }
            Console.ReadKey();
        }
    }
}
