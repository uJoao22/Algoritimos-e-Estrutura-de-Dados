using System;
using System.Collections;

namespace So_Crescendo {
  class Program {
    static void Main(string[] args) {
      int qtd = Convert.ToInt32(Console.ReadLine());

      for (int i=1; i<=qtd; i++) {
        int qtdElementos = Convert.ToInt32(Console.ReadLine());
        ArrayList array = new ArrayList();

        string[] values = Console.ReadLine().Split(' ');
        for(int j=0; j<qtdElementos; j++) {
          array.Add(Convert.ToInt32(values[j]));
        }

        array.Sort();

        Console.WriteLine(verificaCrescimento(array));
      }
    }

    public static string verificaCrescimento(ArrayList array) {
      int value = Convert.ToInt32(array[0]);

      for(int i=1; i<array.Count; i++) {
        if (Convert.ToInt32(array[i]) > value) {
          value = Convert.ToInt32(array[i]);
        } else {
          return "NAO";
        }
      }

      return "SIM";
    }
  }
}
