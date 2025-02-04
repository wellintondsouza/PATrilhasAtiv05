using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma cor:");
        string cor = Console.ReadLine();
		
		
		switch (cor){
		
        	case "vermelho":
				 Console.WriteLine("A cor escolhida foi vermelho"); break;
		
				case "azul":
				 Console.WriteLine("A cor escolhida foi azul"); break;
    
				case "verde":
				 Console.WriteLine("A cor escolhida foi verde"); break;
		
				
		}
		Console.WriteLine("Aperte qualquer tecla para sair...");
    	Console.ReadKey();
    }
         
    }
