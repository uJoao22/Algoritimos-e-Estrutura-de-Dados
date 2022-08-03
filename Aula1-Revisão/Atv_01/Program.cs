using System;

namespace Atv_01 
{
    class Program 
    {
        public static void Main(string[] args) {
            /*
              (passagem valor)Faça uma função que recebe por parâmetro o raio de uma esfera e retorna o  seu volume (v = (4 * 3,14 * R³)/3). Teste esta função. 
             */

            Console.WriteLine("Informe o valor do raio: ");
            double volume = CalVolume(double.Parse(Console.ReadLine()));
            Console.WriteLine("O valor do volume da esfera é: {0:0.00}", volume);
        }

        public static double CalVolume(double raio) {
           return (4 * 3.14 * Math.Pow(raio, 3))/3;
        }
    }
}