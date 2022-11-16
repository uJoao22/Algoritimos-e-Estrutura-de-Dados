using System;
using System.Collections;

namespace Economia_Brasileira
{
    class Program
    {
        static void Main(string[] args)
        {   
            int value = int.Parse(Console.ReadLine());
            string result = VerificaNumeros(value);
            Console.WriteLine(result);
        }

        static string VerificaNumeros(int value) {
            string response = Console.ReadLine();

            int satisfeito = 0;

            for (int i=0; i<response.Length; i++) {
                if (response[i] == '0') satisfeito++;
            }

            int contra = value - satisfeito;
            return satisfeito > contra ? "Y" : "N";
        }
    }
}
