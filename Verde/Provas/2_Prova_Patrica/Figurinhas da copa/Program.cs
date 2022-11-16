using System;

namespace Figurinhas_da_copa {
  class Program {
    static void Main(string[] args) {
      int qtd = Convert.ToInt32(Console.ReadLine());

      int[] figurinhas = new int[qtd];
      int repetidas=0, diferentes=0;

      for(int i=0; i<qtd; i++) {
        figurinhas[i] = Convert.ToInt32(Console.ReadLine());

        int contador=0;
        foreach(int item in figurinhas) {
          if(item != 0) {
            if (item == figurinhas[i])
              contador++;

            if (contador > 1 && item == figurinhas[i]) {
              repetidas++;
              break;
            }
          }
        }

        if (contador < 2) 
          diferentes++;
      }

      Console.WriteLine(diferentes);
      Console.WriteLine(repetidas);
    }
  }
}
