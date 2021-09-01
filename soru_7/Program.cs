using System;

namespace soru_7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Kullanıcı adını giriniz:");
			string adi = Convert.ToString(Console.ReadLine());
			string admin="admin";
			string sifre = "12345";
			if (adi==admin)
			{
				Console.WriteLine("Parolayı giriniz:");
				string parola = Convert.ToString(Console.ReadLine());

				if (parola==sifre)
				{
					Console.WriteLine("Sisteme Giriş başarılıdır." );
				}
				else
				{
					Console.WriteLine("Parola hatalı !");
				}
				
			}

			else
			{
				
				Console.WriteLine("Kullanıcı adı yanlış " );
			}
			Console.ReadLine();
		}
	}
}
