using System;

class Program
{
    static void Main()
    {
        // Solicitação e conversão de variável string for DateTime
        Console.Write("Digite sua data de nascimento (dd/MM/yyyy): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        //Data atual
        DateTime dataAtual = DateTime.Now;

        // Calcula a idade
        int idade = dataAtual.Year - dataNascimento.Year;

        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        Console.WriteLine("Idade: " + idade);
       
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey(true);
    }
}
