using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            double valor, porcentagem;
            Console.WriteLine("Digite o valor :");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem");
            porcentagem = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor convertido com desconto é"+desconto(valor,porcentagem));
            }
            catch(Exception){
                Console.WriteLine("deu ruim :(");
            }

        }
        static double desconto(double valor,double porcentagem){

       
        
       double media = valor*porcentagem/100;
       return media;

        }
        
    }
}
