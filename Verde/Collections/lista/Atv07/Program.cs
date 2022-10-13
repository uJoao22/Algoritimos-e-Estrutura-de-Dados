using System;
using System.Collections;

namespace Atv07 {
	class Program {
		static void Main(string[] args) {
      // 7 - Crie um ArrayList contendo os seguintes elementos (5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5).
      // Faça uma função que apague TODAS as ocorrências de um determinado elemento. Use essa função para apagar todas as ocorrências do número 5 e 13.
      // Dica: você pode criar um ArrayList e já inicializá-lo com alguns elementos conforme o exemplo abaixo:
      // ArrayList AL = new ArrayList() {1, 2, 3, 4, 5};

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
      ArrayList al = new ArrayList() {5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5};
      removeItemsArray(al, 5);
      removeItemsArray(al, 13);

      Print(al);
    }

    private static void removeItemsArray(ArrayList al, int item) {
      int length = al.Count;
      for (int i=0; i<length; i++) {
        if (Convert.ToInt32(al[i]) == item) {
          al.RemoveAt(i);
          length--;
        }
      }
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();
      qu.Enqueue(5);
      qu.Enqueue(13);
      qu.Enqueue(19);
      qu.Enqueue(31);
      qu.Enqueue(3);
      qu.Enqueue(7);
      qu.Enqueue(11);
      qu.Enqueue(5);
      qu.Enqueue(57);
      qu.Enqueue(13);
      qu.Enqueue(5);

      removeItemsQueue(qu, 5);
      removeItemsQueue(qu, 13);

      Print(qu);
    }

    private static void removeItemsQueue(Queue tad, int item) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        if (Convert.ToInt32(aux[i]) != item)
          tad.Enqueue(aux[i]);
      }
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();
      st.Push(5);
      st.Push(13);
      st.Push(19);
      st.Push(31);
      st.Push(3);
      st.Push(7);
      st.Push(11);
      st.Push(5);
      st.Push(57);
      st.Push(13);
      st.Push(5);

      removeItemsStack(st, 5);
      removeItemsStack(st, 13);

      Print(st);
    }

    private static void removeItemsStack(Stack tad, int item) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        if (Convert.ToInt32(aux[i]) != item)
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