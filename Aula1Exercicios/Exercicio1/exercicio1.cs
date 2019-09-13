using System;

namespace Aula1Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
              /* float num,calculo;
                

                Console.WriteLine("Digite um numero : ");
                num=float.Parse(Console.ReadLine());
                calculo = num*3;
                Console.WriteLine($" O calculo é: {calculo}"); */  

             /* float preco,calculo, percentual, resultado;
                

                Console.WriteLine("Digite o preço de custo : ");
                preco=float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o percentual de acrescimo : ");
                percentual=float.Parse(Console.ReadLine());
                calculo = percentual*preco ;
                resultado = (calculo/100)+preco;
                Console.WriteLine(" O valor da venda é : " +resultado);*/  

               /* double salariofixo,totalvendas,calculo;
                Console.WriteLine("Digite seu salario fixo: ");
                salariofixo=float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o total de vendas: ");
                totalvendas=float.Parse(Console.ReadLine());

                calculo = (totalvendas*0.05) + salariofixo;

                Console.WriteLine("Seu salario total é : "+calculo);*/ 

              /*float dolar, cotacao,valor;
                Console.WriteLine("Digite o valor em dolar");
                dolar=float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a cotação do dia : ");
                cotacao=float.Parse(Console.ReadLine());

                valor = dolar*cotacao;

                Console.WriteLine("O valor em dolares é : "+valor); */  

           /* string nome;   
             float salariofixo,totalvendas,calculo;

             Console.WriteLine("Digite seu nome :");
             nome = Console.ReadLine();

             Console.WriteLine("Digite seu salario fixo : ");
             salariofixo = float.Parse(Console.ReadLine());
            
             Console.WriteLine("Digite o total de vendas : ");
             totalvendas = float.Parse(Console.ReadLine());

             calculo=(totalvendas*0.10f)+salariofixo;

             Console.WriteLine($"{nome} seu salario fixo é {salariofixo} e seu salario mês é {calculo}");*/  

            /*float salariomes,divida,calculo;

             Console.WriteLine("Digite seu salario: ");
             salariomes=float.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua divida: ");
             divida=float.Parse(Console.ReadLine());

             calculo = salariomes -divida;

             Console.WriteLine("Seu salario bruto é :" +calculo); */ 

             float qtdpassageiros,calcule;

             Console.WriteLine("Digite a quantidade de passageiros");
            qtdpassageiros=float.Parse(Console.ReadLine());
            calcule=qtdpassageiros*4.30f;
            
            Console.WriteLine("O total arrecado em passagens é : "+calcule);
            

             
        }
    }
}
