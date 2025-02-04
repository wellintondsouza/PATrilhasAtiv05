using System;

namespace B
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Qual a diferença das datas?");
			
			DateTime data1 = new DateTime (2023, 10, 10);
				DateTime data2 = new DateTime (2023, 10, 8);
				
				TimeSpan diferença = data1 - data2;
				
				Console.WriteLine("A diferença entre as datas é:" + diferença.TotalDays);
			
				Console.WriteLine("Aperte qualquer tecla para sair...");
				Console.ReadKey(true);
		}
	}
