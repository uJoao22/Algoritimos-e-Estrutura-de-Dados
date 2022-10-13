using System;
using System.Collections;

namespace Atv14 {
	class Program {
		static void Main(string[] args) {
      // 14 – Crie uma função para inverter os dados da coleção recebida como parâmetro.
      // Obs1: use qualquer outra estrutura que julgar necessária.
      // Obs2: não utilize o método reverse da classe ArrayList.
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

      Console.WriteLine("\nArrayList Normal:");
      Print(al);

      ReverseArray(al);

      Console.WriteLine("\nArrayList Reverse:");
      Print(al);
    }

    private static void ReverseArray(ArrayList tad) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        tad.Add(aux[i]);
      }
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();

      for(int i=1; i<=10; i++) {
        qu.Enqueue(i);
      }

      Console.WriteLine("\nQueue Normal:");
      Print(qu);

      ReverseQueue(qu);

      Console.WriteLine("\nQueue Reverse:");
      Print(qu);
    }

    private static void ReverseQueue(Queue tad) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        tad.Enqueue(aux[i]);
      }
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();

      for(int i=1; i<=10; i++) {
        st.Push(i);
      }

      Console.WriteLine("\nStack Normal:");
      Print(st);

      ReverseStack(st);

      Console.WriteLine("\nStack Reverse:");
      Print(st);
    }

    private static void ReverseStack(Stack tad) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        tad.Push(aux[i]);
      }
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