using System;
using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class PersonangensController
    {
        
        PersonagensModel personagens = new PersonagensModel();


        public void Pular(){

        personagens.Acao = true;   

        System.Console.WriteLine("Pulando...");

        }

        public void Lancar(){


            personagens.Acao =true;
            System.Console.WriteLine("Lançando o escudo..");
        }

        public void Defender(){

            System.Console.WriteLine("Defendendo o ataque...");
        }


        public void CadastrarPersonagem(){

                System.Console.WriteLine("Digite o nome da equipe");
                personagens.Equipe = Console.ReadLine(); 

        }

        public void CordoConsole(){

            if()

            

        }
    }
}