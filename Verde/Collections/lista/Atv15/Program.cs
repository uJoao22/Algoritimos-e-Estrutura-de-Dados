using System;
using System.Collections;

namespace Atv15 {
	class Program {
		static void Main(string[] args) {
      // 15 – Crie uma função que receba a coleção como parâmetro e retorne a soma de seus elementos. Obs: considere que todos seus dados são do tipo int.
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
      ArrayList al = new ArrayList();

      for(int i=1; i<=10; i++) {
        al.Add(i);
      }

      Console.WriteLine("\nSoma Array: {0}\n", Soma(al));
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();

      for(int i=1; i<=10; i++) {
        qu.Enqueue(i);
      }

      Console.WriteLine("\nSoma Queue: {0}\n", Soma(qu));
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();

      for(int i=1; i<=10; i++) {
        st.Push(i);
      }

      Console.WriteLine("\nSoma Stack: {0}\n", Soma(st));
    }

    private static int Soma(IEnumerable tad) {
      int soma = 0;
      foreach(var item in tad) {
        soma += Convert.ToInt32(item);
      }
      return soma;
    }
  }
}