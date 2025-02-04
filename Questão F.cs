using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse (Console.ReadLine());
		
		
		switch (numero){
		
        	case 1:
				 Console.WriteLine("O Número é positivo"); break;
		
				case 0:
				 Console.WriteLine("O numero é igual a 0"); break;
    
				case -1:
				 Console.WriteLine("O numero é negativo"); break;
		
				
		}
		Console.WriteLine("Aperte qualquer tecla para sair...");
    	Console.ReadKey();
    }
         
    }
