using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salariomes,divida,calculo;

             Console.WriteLine("Digite seu salario: ");
             salariomes=float.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua divida: ");
             divida=float.Parse(Console.ReadLine());

             calculo = salariomes -divida;

             Console.WriteLine("Seu salario bruto é :" +calculo);
        }
    }
}
