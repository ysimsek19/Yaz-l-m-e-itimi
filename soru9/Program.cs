using System;

namespace soru9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bir sayı giriniz:");
			int sayi = Convert.ToInt32(Console.ReadLine());
			int mutlakDeger;
			if (sayi < 0)
			{ 
				mutlakDeger = sayi * -1;
			Console.WriteLine("Girilen sayının mutlak değeri :" +"  "+ mutlakDeger);
			}

			else
			{ 
				mutlakDeger = sayi;
			Console.WriteLine("Girilen sayının mutlak değeri : " + "  "+ mutlakDeger);
			}


			//double sayi;
			//Console.Write("Bir sayı giriniz:");
			//double.TryParse(Console.ReadLine(), out sayi);
			//double mutlak = Math.Abs(sayi);
			//Console.WriteLine("Girilen sayının mutlak değeri:" + mutlak);
			Console.ReadLine();
		}
	}
}
