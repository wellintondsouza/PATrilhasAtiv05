using System;

namespace While
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Que dia é hoje e quantas horas são?");
			
			 DateTime dataHoraAtual = DateTime.Now;

			Console.WriteLine("A hora e a data atual é:" +dataHoraAtual);
			Console.ReadKey(true);
		}
	}
