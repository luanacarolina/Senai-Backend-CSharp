using System;
using ex1.Models;

namespace ex1.Controllers
{
    public class PessoaController
    {
        PessoaModel pessoa1 = new PessoaModel();

        public void CadastrarImc(){

        Console.WriteLine("Digite o seu Nome :");
        pessoa1.Nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade : ");
        pessoa1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu peso:");
        pessoa1.peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura");
        pessoa1.altura = double.Parse(Console.ReadLine());

        
        
        }

        public void ExibirIMC(){
            System.Console.WriteLine(pessoa1.Nome);
            System.Console.WriteLine(pessoa1.altura);
            System.Console.WriteLine(pessoa1.Idade);
            System.Console.WriteLine(pessoa1.peso);
            System.Console.WriteLine(pessoa1.altura);
            

            CalculoImc(pessoa1.altura, pessoa1.peso);
            
           
        }

        public  double CalculoImc(double altura , double peso){

                double calculo = peso/(altura*altura);
              

                if(calculo < 18.5){
                    System.Console.WriteLine("Abaixo do peso");

                }
                else if((calculo >=18.5 && calculo < 25)){
                    System.Console.WriteLine("Peso normal");
                }
                else if ((calculo >=26 && calculo <30)){
                    System.Console.WriteLine("Sobrepeso");
                }
                else if((calculo >=31 && calculo < 35)){
                    System.Console.WriteLine("Obesidade grau I");
                }
                else if ((calculo >=36 && calculo < 39)){
                    System.Console.WriteLine("Obesidade grau II");

                }
                else if (calculo>=40){
                    System.Console.WriteLine("Obesidade grau III");

                }
                  return calculo;
        }

        
    }
}