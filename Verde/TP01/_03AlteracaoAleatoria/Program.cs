using System;

namespace _03AlteracaoAleatoria {
	class Program {
		static void Main(string[] args) {
			string word = "";

			Console.WriteLine("valores: m e d");

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM")) 
					continue;

                string resp = AlteracaoAleatorio(word);
                Console.WriteLine(resp);

			} while(!word.ToUpper().Equals("FIM"));
		}

        public static string AlteracaoAleatorio(string word) {
			Random gerador = new Random (4);
			char value1 = (char) ('a' + (Math.Abs(gerador.Next()) % 26));
			char value2 = (char) ('a' + (Math.Abs(gerador.Next()) % 26));

            string newWord = "";
            for(int i=0; i<word.Length; i++)
                newWord += word[i] == value1 ? value2 : word[i];
            
            return newWord;
        }
	}
}
