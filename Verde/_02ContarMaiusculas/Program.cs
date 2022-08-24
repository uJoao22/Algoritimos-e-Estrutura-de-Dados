using System;
using System.Collections;

namespace _02ContarMaiusculas {
	class Program {
		static void Main(string[] args) {
			ArrayList wordWriter = new ArrayList();
			ArrayList numbersUppers = new ArrayList();
            string word = "";

            do{
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM")) 
					continue;

				wordWriter.Add(word);
            } while(!word.ToUpper().Equals("FIM"));

			foreach (string w in wordWriter) {
				int count = 0;
				for(int i=0; i<w.Length; i++) 
					if (Char.IsUpper(Convert.ToChar(w[i]))) count++;
					
				numbersUppers.Add(count);
			}

			foreach (int n in numbersUppers)
				Console.WriteLine(n);
		}
	}
}
