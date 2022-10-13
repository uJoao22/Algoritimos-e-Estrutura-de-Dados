using System;
using System.Collections;

namespace Atv17 {
	class Program {
		static void Main(string[] args) {
      // 17 – Crie uma função que calcule o número de ocorrências em uma coleção de um elemento passado como parâmetro.
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

        switch (op) {
          case 1: SoluctionOfArray(); break;
          case 2: SoluctionOfQueuee(); break;
          case 3: SoluctionOfStack(); break;
          case 4: continue;

          default:
            Console.WriteLine("Opção Inválida.\n");
            break;
        }
      } while(op != 4);
    }

    public static void SoluctionOfArray() {
      ArrayList al = new ArrayList() {5, 5, 10, 15, 20, 25, 5, 20};

      Console.WriteLine("\nArray tem {0} números equivalentes a 5\n", numOcorrencias(al, 5));
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();
      qu.Enqueue(5);
      qu.Enqueue(5);
      qu.Enqueue(10);
      qu.Enqueue(15);
      qu.Enqueue(20);
      qu.Enqueue(25);
      qu.Enqueue(5);

      Console.WriteLine("\nQueue tem {0} números equivalentes a 20\n", numOcorrencias(qu, 20));
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();
      st.Push(5);
      st.Push(5);
      st.Push(10);
      st.Push(15);
      st.Push(20);
      st.Push(25);
      st.Push(5);

      Console.WriteLine("\nStack tem {0} números equivalentes a 30\n", numOcorrencias(st, 30));
    }

    private static int numOcorrencias(IEnumerable tad, int value) {
      int cont = 0;
      foreach(var item in tad) {
        if (Convert.ToInt32(item) == value)
          cont++;
      }
      return cont;
    }
  }
}