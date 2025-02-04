using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número)");
        int numero = int.Parse(Console.ReadLine());
		
		
		switch (numero){
		
        	case 1:
				 Console.WriteLine("Este número corresponde ao dia de Domingo."); break;
		
				case 2:
				 Console.WriteLine("Este número corresponde ao dia de segunda-feira."); break;
    
				case 3:
				 Console.WriteLine("Este número corresponde ao dia de terça-feira."); break;
		
				 case 4:
				 Console.WriteLine("Este número corresponde ao dia de quarta-feira."); break;
				 
				 case 5:
				 Console.WriteLine("Este número corresponde ao dia de quinta-feira."); break;
				
				  case 6:
				 Console.WriteLine("Este número corresponde ao dia de sexta-feira."); break;
				 
				  case 7:
				 Console.WriteLine("Este número corresponde ao dia de sábado."); break;
				 
				 default: Console.WriteLine("Este não é um dia da semana, Digite um número Válido!"); break;
		
        }
		Console.WriteLine("Aperte qualquer tecla para sair...");
    	Console.ReadKey();
    }
         
    }
