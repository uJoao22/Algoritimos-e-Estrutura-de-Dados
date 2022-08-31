using System;

namespace _04Is {
	class Program {
		const char[] vogais = {'a', 'e', 'i', 'o', 'u'};
		static void Main(string[] args) {
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM")) 
					continue;

				Boolean resp = Is(word);
				Console.WriteLine(word ? "SIM" : "NAO")

			} while(!word.ToUpper().Equals("FIM"));
		}
		
		public static Boolean Is(string word) {
			for (wint i=0; i<word.Length; i++){
				if (!word[i].contains(vogais))
					return false;
			}
			return true;
		}
	}
}
