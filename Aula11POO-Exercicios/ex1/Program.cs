using System;
using ex1.Controllers;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
         
         PessoaController pessoa = new PessoaController();

         pessoa.CadastrarImc();
         pessoa.ExibirIMC();
        
        }
    }
}
