using System;
using System.Collections;

namespace Atv05 {
	class Program {
		static void Main(string[] args) {
      // 5 - Crie um ArrayList e adicione os números no intervalo entre 1 a 100. Calcule a soma dos números usando o comando do while.
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
      for(int i=1; i<=100; i++) {
        al.Add(i);
      }

      int soma=0, cont=0;
      do {
        soma += Convert.ToInt32(al[cont]);
        cont++;
      } while (cont < al.Count);

      Console.WriteLine("\nSoma Array: {0}\n", soma);
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();
      for(int i=1; i<=100; i++) {
        qu.Enqueue(i);
      }

      int soma=0, cont=0;
      int length = qu.Count;
      do {
        soma += Convert.ToInt32(qu.Dequeue());
        cont++;
      } while (cont < length);

      Console.WriteLine("\nSoma Queue: {0}\n", soma);
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();
      for(int i=1; i<=100; i++) {
        st.Push(i);
      }

      int soma=0, cont=0;
      int length = st.Count;
      do {
        soma += Convert.ToInt32(st.Pop());
        cont++;
      } while (cont < length);

      Console.WriteLine("\nSoma Stack: {0}\n", soma);
    }
  }
}