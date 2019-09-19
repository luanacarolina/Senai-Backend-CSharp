using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.WriteLine("Digite um numero");
            n = int.Parse (Console.ReadLine());
            for (int i =0;i<=10;i++){
                Console.WriteLine(n +" x "+i +" = "+n*i);
            }
        }
    }
}
