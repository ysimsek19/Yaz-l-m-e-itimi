using System;

namespace soru6
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçüncü Sayıyı Giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                if (sayi2 > sayi3)
                    Console.WriteLine($"{sayi1}>{sayi2}>{sayi3}");
                else
                {
                    if (sayi1 > sayi3)
                        Console.WriteLine($"{sayi1}>{sayi3}>{sayi2}");
                    else
                        Console.WriteLine($"{sayi3}>{sayi1}>{sayi2}");
                }

            }
            else
            {
                if (sayi1 > sayi3)
                    Console.WriteLine($"{sayi2}>{sayi1}>{sayi3}");
                else
                {
                    if (sayi3 > sayi2)
                        Console.WriteLine($"{sayi3}>{sayi2}>{sayi1}");
                    else
                        Console.WriteLine($"{sayi2}>{sayi3}>{sayi1}");
                }
            }

        }
    }
}
