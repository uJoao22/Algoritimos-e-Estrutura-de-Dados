using System;

namespace _02Ciframento {
	class Program {
		static void Main(string[] args) {
            string word = "";

			do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

				Console.WriteLine(Ciframento(word));

			} while(!word.ToUpper().Equals("FIM"));
		}

		public static string Ciframento(string s) {
			string cifra = "";
			for(int i=0; i<s.Length; i++)
				cifra += (char) ((int) s[i] + 3);

			return cifra;
		}
	}
}
