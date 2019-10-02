namespace Aula13_POO_Exerecicios.ex1.Models
{
    public class AlunoModels
    {
          public string Nome { get; set; }
        public string Curso { get; set; }

        public int Idade { get; set; }

        public string RG { get; set; }

        public bool Bolsista { get; set; }

         public AlunoModels(){

        }

        public AlunoModels(string nome,string curso,int idade,string rg,bool bolsista){

            this.Nome=nome;
            this.Curso=curso;
            this.Idade=idade;
            this.RG=rg;
            this.Bolsista=bolsista;
            

        }
    }

    
            

        
}