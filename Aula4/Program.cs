using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] medias = new double[10];

            for(int i=1;i<=10; i++){

                Console.WriteLine("Digite uma média: ");
                medias[i]=double.Parse(Console.ReadLine());


            }
            Console.WriteLine(medias[3]);
            
            for(int i = 0;i<medias.Length ;i++){
            Console.WriteLine("Média : "+medias[i]);

            }


            }
    }
}
