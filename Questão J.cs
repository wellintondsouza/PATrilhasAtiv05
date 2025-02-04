using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o tamanho de uma camisa:(P-M-G)");
        char tamanho = char.Parse(Console.ReadLine());
		
		//Faz o caso das variações de preço 
		switch (tamanho){
		
        	case 'P':
				 Console.WriteLine("O preço desta camisa é de R$30,00."); break;
		
				case 'M':
				 Console.WriteLine("O preço desta camisa é de R$40,00."); break;
    
				case 'G':
				 Console.WriteLine("O preço desta camisa é de R$50,00."); break;
				 
				 default: Console.WriteLine("Não temos este tamanho de camisa. Escolha entre os tamanhos (P-M-G)! "); break;
		
        }
		Console.WriteLine("Aperte qualquer tecla para sair...");
    	Console.ReadKey();
    }
         
    }
