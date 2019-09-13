using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
         // Somente declaramos, sem atribuir valor
        int num1;
        //declaramos atribuindo um valor
        int num2 =5;    
        //declaramos diversas variaveis de mesmo tipo
        int num3,num4,num5 ;
        //Variavel do tipo decimal (real)
        float media;
        //variavel do tipo logico
        bool resultado =false;
        //Variavel do tipo texto (caracteres)
        string nomeAluno;
        
        //Quebra linha 
        Console.WriteLine();

        //Escreve em uma linha quebrando-a
        Console.WriteLine("Bem vindos a nossa primeira aplicação!");
        
        //Continua escrevendo na mesma linha
        Console.Write("Digite seu nome: ");
        Console.Write(" seu nome: ");
        
        //Capturo o dado digitado pelo usuario e salvo na variavel 
        nomeAluno = Console.ReadLine();
        
        //Concatenação
        Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota: ");

        //Converto o texto capturando para o tipo inteiro
        num3=int.Parse(Console.ReadLine());

        //Interolação
        Console.WriteLine($"Sua primeira nota é {num3}");
        
        Console.WriteLine("Digite sua segunda nota");
        num4=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite sua terceira nota : ");
        num5=int.Parse(Console.ReadLine());

        media = (num3 + num4 + num5)/3;

        Console.WriteLine($"Sua média é : {media}");

        }
    }
}
