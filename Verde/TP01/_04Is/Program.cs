using System;
using System.Linq;

namespace _04Is {
	class Program {
		static void Main(string[] args) {
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

				string onlyVogais = IsVogCon(word.ToLower(), false);
				string onlyConsoantes = IsVogCon(word.ToLower(), true);
				string isIntFlo = IsIntFlo(word);

				Console.WriteLine("{0} {1} {2}", onlyVogais, onlyConsoantes, isIntFlo);

			} while(!word.ToUpper().Equals("FIM"));
		}

		public static string IsVogCon(string word, bool regra) {
	        char[] vogais = {'a', 'e', 'i', 'o', 'u'};
			for (int i=0; i<word.Length; i++){
				if (vogais.Contains(word[i]) == regra || (int) word[i] >= '0' && (int) word[i] <= '9')
					return "NAO";
			}
			return "SIM";
		}

		public static string IsIntFlo(string word) {
			string result = "";
			result = int.TryParse(word, out _) ? "SIM " : "NAO ";

			string aux = (word[0] == '.' || word[0] == ',') ? '0'+word : word;
			aux = Convert(aux);
			result += float.TryParse(aux, out _) ? "SIM" : "NAO";

			return result;
		}

		private static string Convert(string s) {
			int cont = 0;
			for(int i=0; i<s.Length; i++)
				if(s[i] == '.' || s[i] == ',') cont++;
			return cont > 1 ? s.Replace(".", ",") : s;
		}
	}
}
