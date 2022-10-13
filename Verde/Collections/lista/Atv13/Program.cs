using System;
using System.Collections;

namespace Atv13 {
	class Program {
		static void Main(string[] args) {
      // 13 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser informado pelo usuário no início da execução do programa. Imprima os elementos da coleção.
      // Exemplo de geração de números aleatórios.
      // Random r = new Random();
      // int x = r.Next(); // Retorna um número aleatório positivo
      // int y = r.Next(100); // Retorna um número aleatório entre 0 e 99
      // int z = r.Next(50, 100); // Retorna um número aleatório entre 50 e 99
      // double w = r.NextDouble(); // Retorna um ponto-flutuante entre 0.0 e 1.0
      int op = 0;

      do {
        Console.WriteLine("|| Selecione uma opção ||");
        Console.WriteLine("|| = = = = = = = = = = ||");
        Console.WriteLine("|| 1 - Array           ||");
        Console.WriteLine("|| 2 - Queuee          ||");
        Console.WriteLine("|| 3 - Stack           ||");
        Console.WriteLine("|| 4 - Sair            ||");
        Console.WriteLine("|| = = = = = = = = = = ||");
        op = Convert.ToInt32(Console.ReadLine());
        int n = 0;

        if (op >= 1 && op <= 3) {
          Console.WriteLine("Quantos números inteiros serão inseridos:");
          n = Convert.ToInt32(Console.ReadLine());
        }

        switch (op) {
          case 1: SoluctionOfArray(n); break;
          case 2: SoluctionOfQueuee(n); break;
          case 3: SoluctionOfStack(n); break;
          case 4: continue;

          default:
            Console.WriteLine("Opção Inválida.\n");
            break;
        }
      } while(op != 4);
    }

    public static void SoluctionOfArray(int n) {
      ArrayList al = new ArrayList();
      Random r = new Random();

      for(int i=0; i<n; i++) {
        int x = r.Next();
        al.Add(x);
      }

      Console.WriteLine("\nArrayList:");
      Print(al);
    }

    public static void SoluctionOfQueuee(int n) {
      Queue qu = new Queue();
      Random r = new Random();

      for(int i=0; i<n; i++) {
        int x = r.Next();
        qu.Enqueue(x);
      }

      Console.WriteLine("\nQueue:");
      Print(qu);
    }

    public static void SoluctionOfStack(int n) {
      Stack st = new Stack();
      Random r = new Random();

      for(int i=0; i<n; i++) {
        int x = r.Next();
        st.Push(x);
      }

      Console.WriteLine("\nStack:");
      Print(st);
    }

    private static void Print(IEnumerable tad) {
      Console.Write("[");

      foreach(var item in tad) {
        Console.Write(" {0}", item);
      }

      Console.WriteLine(" ]\n");
    }
  }
}