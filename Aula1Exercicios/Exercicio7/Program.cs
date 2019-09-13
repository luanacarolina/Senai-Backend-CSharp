using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
           float qtdpassageiros,calcule;

             Console.WriteLine("Digite a quantidade de passageiros");
            qtdpassageiros=float.Parse(Console.ReadLine());
            calcule=qtdpassageiros*4.30f;
            
            Console.WriteLine("O total arrecado em passagens é : "+calcule);
        }
    }
}
