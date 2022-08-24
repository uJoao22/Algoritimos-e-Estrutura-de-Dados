using System;

namespace Atv_02
{
    class Program 
    {
        public static void Main(string[] args) {
            /*
                (matriz)Criar um algoritmo que carregue uma matriz 12 x 4 com os valores 
                das vendas de uma loja de carros, em que cada linha represente um mês do 
                ano, e cada coluna, uma semana do mês. Para fins de simplificação 
                considere que cada mês possui somente 4 semanas. Calcule e imprima: -  
                Total vendido em cada mês do ano;  
                Total vendido no ano. 
                Qual a melhor semana para vender carros? 1ª, 2ª, 3ª ou 4ª? 
             */

            double[,] matriz = new double[12, 4];

            PreencheMatrizECalcula(matriz);
        }

        public static void PreencheMatrizECalcula(double[,] mat) {
            double totAno = 0;
            for(int i=0; i<mat.GetLength(0); i++) {
                double totMes = 0;
                int melSem = 0;
                for(int j=0; j<mat.GetLength(1); j++) {
                    Console.WriteLine("Insira o valor faturado na {0}° semana de {1}", j+1, pegaMes(i+1));
                    mat[i, j] = double.Parse(Console.ReadLine());
                    totMes += mat[i, j];
                    if (totMes>melSem)
                        melSem = j;
                }
                Console.WriteLine("Foi vendido R${0:0.00} nesse mês", totMes);
                Console.WriteLine("A melhor semana ára vender", totMes);
                totAno += totMes;
            }
            Console.WriteLine("Foi vendido R${0:0.00} no ano", totAno);
        }

        public static string pegaMes(int nMes) {
            switch(nMes) {
                case 1: return "Janeiro"; break;
                case 2: return "Fevereiro"; break;
                case 3: return "Março"; break;
                case 4: return "Abril"; break;
                case 5: return "Maio"; break;
                case 6: return "Junho"; break;
                case 7: return "Julho"; break;
                case 8: return "Agosto"; break;
                case 9: return "Setembro"; break;
                case 10: return "Outubro"; break;
                case 11: return "Novembro"; break;
                default: return "Dezembro"; break;
            }
        }


    }
}