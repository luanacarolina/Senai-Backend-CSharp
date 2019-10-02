using System;
using Aula13_POO_Exerecicios.ex1.Models;

namespace Aula13_POO_Exerecicios
{
    class Program
    {
        static void Main(string[] args)
        {
           AlunoModels aluno = new AlunoModels("luana","Engenharia",23,"483191991",true);

           System.Console.WriteLine(aluno.Nome);

            AlunoModels aluno_sobrecarga = new AlunoModels();


        }
    }
}
