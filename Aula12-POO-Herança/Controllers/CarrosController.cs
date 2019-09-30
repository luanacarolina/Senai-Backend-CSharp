using System;
using Aula12_POO_Herança.Model;

namespace Aula12_POO_Herança.Controllers
{
    public class CarrosController
    {
        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void Ligar(){
            carro.Ligado = true;
            
            
        Console.WriteLine("Ligando carro!");
        }

        public void Desligar(){
            carro.Ligado = false;
        Console.WriteLine("Desligando o carro...");

        }
        public void Acelerar(){
            if(carro.Ligado == true){
            Console.WriteLine("Carro acelerando!");
            }
            else{
                Console.WriteLine("O carro não está ligado!Impossivel acelerar");
            }
            
        }

        public void Freiar(){
            if (carro.Ligado==true){
            Console.WriteLine("Carro freando...");
            }
            else{
                Console.WriteLine("O carro não está ligado ! impossivel frear!");
            }
        }

        public void CadastrarMotor(){

            Console.WriteLine("Insira quantos cavalos tem o motor:");
            motor.Cavalos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira quantos cilindros tem o carro:");
        motor.Cilindros = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o modelo do pistão do carro");
            motor.Pistao = Console.ReadLine();
        }

    }
}