using System;
using System.Collections;

namespace Max_O_Fotografo {
  class Program {
    static void Main(string[] args) {
      int qtd = Convert.ToInt32(Console.ReadLine());

      for (int i=1; i<=qtd; i++) {
        string[] dados = Console.ReadLine().Split(' ');

        int numsPessoasPorFileira = Convert.ToInt32(dados[0]);
        int cmDiferenca = Convert.ToInt32(dados[1]);

        ArrayList array = new ArrayList();
        string[] values = Console.ReadLine().Split(' ');
        for(int j=0; j<values.Length; j++) {
          array.Add(Convert.ToInt32(values[j]));
        }

        array.Sort();

        int nFileiras = array.Count <=2 ? 1 : array.Count/numsPessoasPorFileira;
        bool condicao = false;

        for(int j=0; j<nFileiras; j++) {
          if ((Convert.ToInt32(array[j]) + cmDiferenca) <= Convert.ToInt32(array[j+(array.Count <=2 ? 1 : nFileiras)])) {
            continue;
          } else {
            Console.WriteLine("NAO");
            condicao = true;
            break;
          }
        }

        if (condicao == false) {
          Console.WriteLine("SIM");
        }
      }
    }
  }
}
