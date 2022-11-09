using System;

namespace Pegadinha_de_Evergreen {
  class Program {
    static void Main(string[] args) {
      int qtd = Convert.ToInt32(Console.ReadLine());

      for (int i=1; i<=qtd; i++) {
        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();

        int lengthMaior = linha1.Length >= linha2.Length ? linha1.Length : linha2.Length;
        int lengthTotal = linha1.Length + linha2.Length;

        string palavraCerta = "";

        for(int j=0; j<lengthMaior; j+=2) {
          if (palavraCerta.Length != lengthTotal) {
            if (j < linha1.Length) {
              palavraCerta += linha1[j];
              if (j+1 < linha1.Length) palavraCerta += linha1[j+1];
            }

            if (j < linha2.Length) {
              palavraCerta += linha2[j];
              if (j+1 < linha2.Length) palavraCerta += linha2[j+1];
            }
          } else {
            j = lengthMaior;
          }
        }

        Console.WriteLine(palavraCerta);
      }
    }
  }
}
