using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma das opções abaixo:");

        Console.WriteLine("Opção1");
        Console.WriteLine("Opção2");      
		Console.WriteLine("Opção3");
		
		string escolha = (Console.ReadLine());
		
		switch (escolha){
		
			case"1":
				
				 Console.WriteLine("Opção 1 escolhida!"); break;
		
			case"2":
				 Console.WriteLine("Opção 2 escolhida!"); break;
    
				case"3":
				 Console.WriteLine("Opção 3 escolhida"); break;
		
				
		}
		Console.WriteLine("Aperte qualquer tecla para sair...");
    	Console.ReadKey();
    }
         
    }
