using System;

namespace _04Is {
	class Program {
		static void Main(string[] args) {
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM")) 
					continue;

				string respVogais = OnlyVogais(word);
				string respConsoantes = OnlyConsoantes(word);
				Console.WriteLine("{0} {1}", respVogais, respConsoantes);

			} while(!word.ToUpper().Equals("FIM"));
		}
		
		public static string OnlyVogais(string word) {
	        char[] vogais = {'a', 'e', 'i', 'o', 'u'};
			for (int i=0; i<word.Length; i++){
				if (!vogais.Contains(word[i]))
					return "NAO";
			}
			return "SIM";
		}

        public static string OnlyConsoantes(string word) {
	        char[] vogais = {'a', 'e', 'i', 'o', 'u'};
			for (int i=0; i<word.Length; i++){
				if (vogais.Contains(word[i]))
					return "NAO";
			}
			return "SIM";
		}
	}
}
