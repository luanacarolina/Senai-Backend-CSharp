using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa primeira função
            Console.WriteLine(BomDia());
            //Chamamos a função tipo VOID (sem retorno)
            ImprimeDataHora();

            //Chamamos nossa função que calcula a média 
            double[] numeros ={2,5,2,8,9,5};
            Console.WriteLine(CalculaMedia(numeros));  

            //Chamamos a função de SoMA 
            Console.WriteLine(SomaValores(numeros)); 
            
        }
        /// <summary>
        /// Função que escreve bom dia para o usuario
        /// </summary>
        /// <returns>Retorna olá Bom dia!</returns>
        static string BomDia(){
            return "Olá Bom dia";
        }
        /// <summary>
        /// Função que mostra uma saudação de acordo com o horario atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de metodo)</param>
        /// <returns>Saudacao de acordo com o horario</returns>
        static string BomDia(string saudacao){
            int hora =DateTime.Now.Hour;
            if(hora <=12 && hora >=6){
                saudacao = "Bomdia";
            }else if(hora >12 && hora <= 18){
                saudacao ="Boa Tarde";
            }else{
                saudacao ="Boa Noite";
            }
            return saudacao;
        }
        /// <summary>
        /// Retorna um numero - Teste de sobrecarga 
        /// </summary>
        /// <param name="numero"> Um numero inteiro qualquer</param>
        /// <returns>Numero passado como parametro</returns>
        static int Bomdia(int numero){
            return numero;
        }
        /// <summary>
        /// Retorna Data e Hora Atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour);
        }
        /// <summary>
        /// Função que calcula a media de um vetor 
        /// </summary>
        /// <param name="valores">Vetor com valores</param>
        /// <returns>Media com valores</returns>
        static double CalculaMedia( double[] valores){
            double resultado =0;
            for(int i =0;i < valores.Length ;i++){
                resultado =resultado+valores[i];
            }
            resultado = resultado / valores.Length;
            return resultado;
        }
        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="soma">vetor de doubles</param>
        /// <returns>Soma de valores</returns>
        static double SomaValores(double[] soma){
            double resultado1 = 0;
            for(int i =0;i< soma.Length;i++){
                resultado1 =resultado1+soma[i];
            }
            return resultado1;
        }
    }
}
