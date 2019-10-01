using System;
using Aula12_POO_Exercicios.ex1.Models;

namespace Aula12_POO_Exercicios.ex1.Controllers
{
    public class AlunoControllers
    {
        AlunoModels alunos = new AlunoModels();

        public void CadastrarAluno(){
            System.Console.WriteLine("Digite seu Nome: ");
            alunos.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Digite seu Curso: ");
            alunos.Curso = Console.ReadLine();

            System.Console.WriteLine("Digite sua Idade");
            alunos.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu RG: ");
            alunos.RG = Console.ReadLine();

            System.Console.WriteLine("Digite 1 se é Bolsista ou 2 se não é");
            alunos.Bolsista = bool.Parse(Console.ReadLine());
            
             aluno.ValidaBolsista();
            
        }
        
        public  string  ValidaBolsista( bool Bolsista){

            bool bolsista = true;
            string retorno = "";

            if(bolsista ){
                retorno ="1";
            }
            else if(bolsista=!true){
                retorno ="1";
            }
            return retorno;



        }
    }
}