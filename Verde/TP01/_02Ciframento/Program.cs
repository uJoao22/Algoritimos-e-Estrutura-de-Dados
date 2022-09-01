using System;
using System.Text;
using System.Collections.Generic;

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
			List<Byte> sByte = new List<Byte>();

			for(int i=0; i<s.Length; i++)
				sByte.Add(Convert.ToByte(s[i]+3));

            return Encoding.ASCII.GetString(sByte.ToArray());
		}
	}
}
