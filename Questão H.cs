using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma letra:(EM MAIÚSCULO!)");
        char letra = char.Parse(Console.ReadLine());
		
		
		switch (letra){
		
        	case 'A':
				 Console.WriteLine("A letra A é uma vogal!"); break;
		
				case 'E':
				 Console.WriteLine("A letra E é uma vogal!"); break;
    
				case 'I':
				 Console.WriteLine("A letra I é uma vogal!"); break;
		
				 case 'O':
				 Console.WriteLine("A letra O é uma vogal!"); break;
				 
				 case 'U':
				 Console.WriteLine("A letra U é uma vogal!"); break;
				
				 default: Console.WriteLine("Não é Vogal"); break;
		
        }
		Console.WriteLine("Aperte qualquer tecla para sair...");
    	Console.ReadKey();
    }
         
    }
