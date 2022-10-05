using System;

namespace _05PalindromoRecursivo {
	class Program {
		static void Main(string[] args) {
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

				Console.WriteLine(isPalindromo(word) == word ? "SIM" : "NAO");

			} while(!word.ToUpper().Equals("FIM"));
		}

		public static string isPalindromo(string word) {
			if (word.Length == 1)
				return word;
			return word[word.Length-1] + isPalindromo(word.Substring(0, word.Length-1));
		}
	}
}
