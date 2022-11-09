using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=qtd; i++) {
                string linha1 = Console.ReadLine();
                string linha2 = Console.ReadLine();

                int lengthMaior = linha1.Length >= linha2.Length ? linha1.Length : linha2.Length;
                int lengthTotal = linha1.Length + linha2.Length;

                string palavraCerta = "";

                for(int j=0; j<lengthMaior; j+=2) {
                    if (palavraCerta.Length != lengthTotal) {
                        if (j < linha1.Length) {
                            palavraCerta += linha1[j];
                            if (j+1 < linha1.Length) palavraCerta += linha1[j+1];
                        }

                        if (j < linha2.Length) {
                            palavraCerta += linha2[j];
                            if (j+1 < linha2.Length) palavraCerta += linha2[j+1];
                        }
                    }
                }

                Console.WriteLine(palavraCerta);
            }
        }

        public static void montaPalavra(string word) {
            string palavraCerta = "";
            bool verify = true;

            for(int i=0; i<word.Length; i+=2) {
                if (verify) {
                    palavraCerta = word.Substring(i, 2);
                    verify = false;
                } else {
                    verify = true;
                }
            }

            Console.WriteLine(palavraCerta);
        }
    }
}
