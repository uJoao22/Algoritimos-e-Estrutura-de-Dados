using System;

namespace Atv_03
{
    class Program 
    {
        public static void Main(string[] args) {
            /*
                (vetor)Crie um programa que receba 10 números do usuário e armazene 
                em um vetor. Ao final, calcular a média destes números e dizer quantos 
                números estão acima da média. 
             */

            double[] vetor = new double[10];
            double soma = 0;

            for(int i=0; i<vetor.Length; i++) {
                Console.WriteLine("Insira o {0}° valor do vetor", i+1);
                vetor[i] = double.Parse(Console.ReadLine());
                soma += vetor[i];
            }
            double media = soma/10;

            int nums = CalcNumsAcimaMedia(vetor, media);

            Console.WriteLine("{0} número(s) estão acima da média de {1}", nums, media);
        }

        public static int CalcNumsAcimaMedia(double[] vet, double media) {
            int nAcima = 0;
            for(int i=0; i<vet.Length; i++)
                if (vet[i] > media) nAcima++;
            return nAcima;
        }

    }
}