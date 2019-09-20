using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]valores = new double[10];

            for(int i=0;i<=9;i++){
                Console.WriteLine("Digite o valor " +i);
                valores[i]=int.Parse(Console.ReadLine());
            }
            for(int i = 0;i<=9;i++){

                Console.WriteLine(valores[i]);
                Console.WriteLine("O ultimo valor multiplicado é : "+valores[9]*5);
            }
        }
    }
}
