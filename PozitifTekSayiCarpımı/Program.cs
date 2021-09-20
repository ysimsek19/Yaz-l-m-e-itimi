using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozitifTekSayiCarpımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //int sonuc = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}.Sayıyı Giriniz;", i);
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if ((sayi>0) && (sayi% 2==1));
            //    {
            //        sonuc *= sayi;

            //    }
            //    Console.WriteLine("Pozitif ve tek sayıların çarpımı:" + sonuc);
            //    Console.ReadKey();
            //}

            string cumle;
            Console.Write("Bir cümle giriniz: ");
            cumle = Console.ReadLine();
            // bir strin ifadenin karakter sayısını Length 
            //Console.WriteLine(cumle.Length); 
            for (int i = 0; i < cumle.Length; i++)
            {
                Console.WriteLine(cumle[i]);
            }
            Console.ReadKey();


        }
    }
}
