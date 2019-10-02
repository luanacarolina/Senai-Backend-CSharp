using Vingadores.Models;

namespace Vingadores.Controllers
{
    public class PersonagemControllers :PersonangensController
    {
        
        PersonagensModel personagens = new PersonagensModel();

        public void Voar(){

             personagens.Acao = true;
             System.Console.WriteLine("Voando...");

        }

        public void Atirar(){

            personagens.Acao=true;
            System.Console.WriteLine("Atirando...");
        }
    }
}