using System;
using System.Collections;

namespace Atv06 {
	class Program {
		static void Main(string[] args) {
      // 6 - Crie um ArrayList e adicione os números pares no intervalo entre 1 a 100. Calcule a soma dos números usando o comando foreach.
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
      for(int i=2; i<=100; i+=2) {
        al.Add(i);
      }

      int soma=0;
      foreach (int item in al) {
        soma += item;
      }

      Console.WriteLine("\nSoma Array: {0}\n", soma);
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();
      for(int i=2; i<=100; i+=2) {
        qu.Enqueue(i);
      }

      int soma=0;
      foreach (object item in qu) {
        soma += Convert.ToInt32(item);
      }

      Console.WriteLine("\nSoma Queue: {0}\n", soma);
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();
      for(int i=2; i<=100; i+=2) {
        st.Push(i);
      }

      int soma=0;
      foreach (object item in st) {
        soma += Convert.ToInt32(item);
      }

      Console.WriteLine("\nSoma Stack: {0}\n", soma);
    }
  }
}