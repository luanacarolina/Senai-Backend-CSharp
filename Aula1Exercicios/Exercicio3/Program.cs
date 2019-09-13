using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           double salariofixo,totalvendas,calculo;
                Console.WriteLine("Digite seu salario fixo: ");
                salariofixo=float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o total de vendas: ");
                totalvendas=float.Parse(Console.ReadLine());

                calculo = (totalvendas*0.05) + salariofixo;

                Console.WriteLine("Seu salario total é : "+calculo);
        }
    }
}
