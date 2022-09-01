using System;
using System.Collections;

namespace teste {
	class Program {
		static void Main(string[] args) {
			ArrayList resp = new ArrayList();
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

				resp.Add(isPalindromo(word) ? "SIM" : "NAO");
			} while(!word.ToUpper().Equals("FIM"));

			foreach(string r in resp)
				Console.WriteLine(r);
		}

		public static Boolean isPalindromo(string word) {
			string contrario = "";
			for(int i=word.Length-1; i>=0; i--) {
				contrario += word[i];
			}
			return word == contrario;
		}
	}
}
