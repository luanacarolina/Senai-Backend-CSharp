﻿using System;

namespace Aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos as variaveis que utilizaremos para fazer o calculo
            float nota1,nota2,nota3,media;
            string resultado;
            
            
            Console.WriteLine("Digite a primeira nota: ");
            nota1=float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2=float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3=float.Parse(Console.ReadLine());

            media=(nota1+nota2+nota3)/3;
            
            if(media>=6){
                resultado ="Aprovado";
            }
            else if(media <6 && media >=4){
                resultado = "Recuperação";
            }
            else{

                resultado = "Reprovado";
            }

            Console.WriteLine($"Média: {media} - Aluno está {resultado} ");
        
        }
    }
}
