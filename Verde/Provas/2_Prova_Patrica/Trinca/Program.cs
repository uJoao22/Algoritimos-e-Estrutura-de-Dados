using System;
using System.Collections;

namespace Trinca {
  class Program {
    static void Main(string[] args) {
      int qtd = Convert.ToInt32(Console.ReadLine());

      for(int i=0; i<qtd; i++) {
        ArrayList array = new ArrayList();
        int maior = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        string[] values = Console.ReadLine().Split(' ');

        for(int j=0; j<n; j++) {
          array.Add(Convert.ToInt32(values[j]));

          int contador = 0;
          foreach(int item in array) {
            if (item == Convert.ToInt32(values[j]))
              contador++;

            if (contador >= 3 && item > maior) {
              maior = item;
            }
          }
        }

        Console.WriteLine(maior == 0 ? -1 : maior);
      }
    }
  }
}