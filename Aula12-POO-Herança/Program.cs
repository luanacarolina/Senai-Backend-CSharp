using System;
using Aula12_POO_Herança.Controllers;

namespace Aula12_POO_Herança
{
    class Program
    {
        static void Main(string[] args)
        {

            CarrosController carro = new CarrosController();
            CarroEletricosController carroEletrico = new CarroEletricosController();
            Console.Clear();//limpa a tela do terminal 

            carroEletrico.CarregarBateria(100);
            carroEletrico.CarregarBateria(15);
          System.Console.WriteLine("Carga do carro: "+carroEletrico.StatusBateria());

            }
    }
}
