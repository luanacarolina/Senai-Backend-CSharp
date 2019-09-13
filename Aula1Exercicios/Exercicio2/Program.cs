using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco,calculo, percentual, resultado;
                

                Console.WriteLine("Digite o preço de custo : ");
                preco=float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o percentual de acrescimo : ");
                percentual=float.Parse(Console.ReadLine());
                calculo = percentual*preco ;
                resultado = (calculo/100)+preco;
                Console.WriteLine(" O valor da venda é : " +resultado);
        }
    }
}
