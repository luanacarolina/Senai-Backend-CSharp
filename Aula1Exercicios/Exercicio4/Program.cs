using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           float dolar, cotacao,valor;
                Console.WriteLine("Digite o valor em real");
                dolar=float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a cotação do dia : ");
                cotacao=float.Parse(Console.ReadLine());

                valor = dolar/cotacao;

                Console.WriteLine("O valor em dolares é : "+valor);
        }
    }
}
