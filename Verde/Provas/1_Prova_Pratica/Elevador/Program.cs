using System;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = Console.ReadLine().Split(' ');
            string result = VerificaElevador(Convert.ToInt32(value[0]), Convert.ToInt32(value[1]));
            Console.WriteLine(result);
        }

        static string VerificaElevador(int nLeituras, int capacidade) {
            int quantP = 0;
            bool excedeuLimite = false;

            for (int i=1; i<=nLeituras; i++) {
                string[] value = Console.ReadLine().Split(' ');

                int sairam = Convert.ToInt32(value[0]);
                int entraram = Convert.ToInt32(value[1]);

                quantP = quantP - sairam + entraram; 

                if (quantP > capacidade) {
                    excedeuLimite = true;
                }
            }

            return excedeuLimite ? "S" : "N";
        }
    }
}
