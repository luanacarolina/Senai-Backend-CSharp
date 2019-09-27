using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarInfo();
            Console.WriteLine(MostrarInfo("Luana ", "Carolina"));
            Console.WriteLine(MostrarInfo(23,1.7,65));
        }

            static void MostrarInfo(){

                Console.WriteLine("SERVICO NACIONAL DE APRENDIZAGEM INDUSTRIAL - SENAI");
            }
                static string MostrarInfo(string nome,string sobrenome){

                    return $"{nome} {sobrenome}";

                }

                static string MostrarInfo(int idade,double altura,double peso){

                    return $"{idade} {altura} {peso}";
                }
    }
}
