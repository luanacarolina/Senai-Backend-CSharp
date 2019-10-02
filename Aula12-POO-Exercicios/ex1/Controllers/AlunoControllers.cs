using System;
using Aula12_POO_Exercicios.ex1.Models;

namespace Aula12_POO_Exercicios.ex1.Controllers
{
    public class AlunoControllers
    {
        AlunoModels alunos = new AlunoModels();

        public void CadastrarAluno(){
            int bolsista = 0;

            System.Console.WriteLine("Digite seu Nome: ");
            alunos.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Digite seu Curso: ");
            alunos.Curso = Console.ReadLine();

            System.Console.WriteLine("Digite sua Idade");
            alunos.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu RG: ");
            alunos.RG = Console.ReadLine();

            System.Console.WriteLine("Digite 1 se é Bolsista ou 2 se não é");
            bolsista = int.Parse(Console.ReadLine());
            
            if(bolsista==1){
                alunos.Bolsista =true;
            }
            else if(bolsista ==2){
                alunos.Bolsista = false;
            }

        
            
           
            
        }
        
       
        public void ExibirAluno(){

            System.Console.WriteLine(alunos.Nome);
            System.Console.WriteLine(alunos.Idade);
            System.Console.WriteLine(alunos.RG);
           

            if(alunos.Bolsista ==true){
                System.Console.WriteLine("Aluno Bolsista");
            }
            else if(alunos.Bolsista==false){
                System.Console.WriteLine("Aluno não Bolsista");
            }
            
        }


        }
    }
