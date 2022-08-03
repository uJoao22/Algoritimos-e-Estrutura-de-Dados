using System;

namespace Atv_02
{
    class Program 
    {
        public static void Main(string[] args) {
            /*
                (passagem referência)Faça uma função que recebe por parâmetro o raio 
                de uma esfera e retorna o seu volume (v = (4 * 3,14 * R³)/3), mas antes de 
                fazer o cálculo e retornar ela deve arredondar o raio para baixo, ou seja, se o 
                raio for 3.5, deve ser alterado para 3. Esta alteração deve refletir na variável 
                que foi passada na chamada da função. Teste esta função. 
             */

            Console.WriteLine("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double volume = CalVolume(ref raio);
            Console.WriteLine("O valor do volume da esfera é: {0:0.00}", volume);
        }

        public static double CalVolume(ref double r) {
            r = Math.Floor(r);
           return (4 * 3.14 * Math.Pow(r, 3))/3;
        }

    }
}