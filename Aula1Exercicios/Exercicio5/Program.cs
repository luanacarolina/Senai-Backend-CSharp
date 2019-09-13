using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        string nome;   
             float salariofixo,totalvendas,calculo;

             Console.WriteLine("Digite seu nome :");
             nome = Console.ReadLine();

             Console.WriteLine("Digite seu salario fixo : ");
             salariofixo = float.Parse(Console.ReadLine());
            
             Console.WriteLine("Digite o total de vendas : ");
             totalvendas = float.Parse(Console.ReadLine());

             calculo=(totalvendas*0.10f)+salariofixo;

             Console.WriteLine($"{nome} seu salario fixo é {salariofixo} e seu salario mês é {calculo}");
        }
    }
}
