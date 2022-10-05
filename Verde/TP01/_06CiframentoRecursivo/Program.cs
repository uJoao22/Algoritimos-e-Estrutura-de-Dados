using System;

namespace _06CiframentoRecursivo {
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

        public static string Ciframento(string word) {
            if (word.Length == 0)
                return "";

            return (char) ((int) word[0] + 3) + Ciframento(word.Substring(1));
		}
	}
}
