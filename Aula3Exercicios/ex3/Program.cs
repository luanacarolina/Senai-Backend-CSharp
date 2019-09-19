using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++){
                if(i %5==0){
                    Console.WriteLine("Numeros divisiveis por 5: "+i);
                }
            }
        }
    }
}
