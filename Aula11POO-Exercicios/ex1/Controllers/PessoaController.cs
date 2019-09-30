using System;
using ex1.Models;

namespace ex1.Controllers
{
    public class PessoaController
    {
        PessoaModel pessoa = new PessoaModel();

        public void CadastrarImc(){

        Console.WriteLine("Digite o seu Nome :");
        pessoa.Nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade : ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu peso:");
        pessoa.peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura");
        pessoa.altura = double.Parse(Console.ReadLine());

        
        
        }

        public void ExibirIMC(){
            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa.altura);
            System.Console.WriteLine(pessoa.Idade);
            System.Console.WriteLine(pessoa.peso);
            System.Console.WriteLine(pessoa.altura);
            
            
           
        }

        static double CalculoImc(double altura , double peso){

                double calculo = (altura*altura)/peso;
                return calculo;
                if(calculo)
        }

        
    }
}