using System;

namespace Vingadores.Models
{
    public class PersonagensModel
    {
        public int Vida { get; set; } = 100;

        public ConsoleColor CorDoConsole{get;set;} 

        public string Equipe { get; set; } 

        public string NomePersonagem { get; set; }     

        public bool Acao { get; set; }

    }
}