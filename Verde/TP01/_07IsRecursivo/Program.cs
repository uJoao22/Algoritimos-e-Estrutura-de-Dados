using System;
using System.Linq;

namespace _07IsRecursivo {
	class Program {
		static void Main(string[] args) {
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

				string onlyVogais = IsVogCon(word.ToLower(), false) ? "SIM" : "NAO";
				string onlyConsoantes = IsVogCon(word.ToLower(), true) ? "SIM" : "NAO";
				string isIntFlo = IsIntFlo(word);

				Console.WriteLine("{0} {1} {2}", onlyVogais, onlyConsoantes, isIntFlo);

			} while(!word.ToUpper().Equals("FIM"));
		}
		public static bool IsVogCon(string word, bool regra) {
	        char[] vogais = {'a', 'e', 'i', 'o', 'u'};

            if(word.Length == 0)
                return true;

			if(vogais.Contains(word[0]) == regra || (int) word[0] >= '0' && (int) word[0] <= '9')
				return false;
            else
                return IsVogCon(word.Substring(1), regra);
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
			int cont = Cont(s, 0);
			return cont > 1 ? s.Replace(".", ",") : s;
		}

        private static int Cont(string s, int cont) {
            if(s.Length == 0)
                return cont;

            if(s[0] == '.' || s[0] == ',') cont++;

            return Cont(s.Substring(1), cont);
        }
	}
}
