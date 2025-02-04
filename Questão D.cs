using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma data:");
        DateTime data = DateTime.Parse(Console.ReadLine());

        DateTime dataFeriado = new DateTime (2025, 03, 04);
		DateTime dataFeriado2 = new DateTime (2024, 12, 15);        
       
        if (data == dataFeriado || data == dataFeriado2)
        {
                Console.WriteLine("A data " + data.ToString("yyyy/MM/dd") + " é um feriado. Natal ou Carnaval");
            }
            else
            {
                Console.WriteLine("A data " + data + ("yyyy/MM/dd") + " não é um feriado.");
            }
            Console.WriteLine("Data inválida.");
            Console.ReadKey();
        }
    }
