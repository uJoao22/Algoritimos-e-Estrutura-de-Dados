using System;

namespace _01ParImpar {
	class Program {
		static void Main(string[] args) {
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(num % 2 == 0 ? "PAR" : "IMPAR");
		}
	}
}
