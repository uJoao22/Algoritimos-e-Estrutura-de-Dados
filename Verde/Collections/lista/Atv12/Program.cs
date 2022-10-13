using System;
using System.Collections;

namespace Atv12 {
	class Program {
		static void Main(string[] args) {
      // Faça um programa que preencha um ArrayList com os números entre 1 e 25. Pede-se:
      // ● Imprima todos os elementos
      // ● Imprima todos os elementos em ordem invertida
      // ● Imprima todos os elementos em posições ímpares (os elementos da posição 1, 3, 5, ...)
      // ● Imprima todos os elementos ímpares
      // ● Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).
      // OBS: você deve fazer esse programa 2 vezes. Primeiro usando o comando FOR e depois usando o comando FOREACH.
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

      for(int i=1; i<=25; i++) {
        al.Add(i);
      }

      int method = selectForOrForeach();
      int length = al.Count;

      Console.WriteLine("\nArray - {0}\n", method == 1 ? "FOR" : "FOREACH");

      Console.WriteLine("Imprime:");
      Print(al, method, length);

      al.Reverse();

      Console.WriteLine("Imprime Reverse:");
      Print(al, method, length);

      Console.WriteLine("Imprime Posições Ímpares:");
      PrintImpar(al, true, method, length);

      Console.WriteLine("Imprime Elementos Ímpares:");
      PrintImpar(al, false, method, length);

      Console.WriteLine("Imprime a Primeira Metade:");
      PrintHalf(al, length, method);
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();

      for(int i=1; i<=25; i++) {
        qu.Enqueue(i);
      }

      int method = selectForOrForeach();
      int length = qu.Count;

      Console.WriteLine("\nQueue - {0}\n", method == 1 ? "FOR" : "FOREACH");

      Console.WriteLine("Imprime:");
      Print(qu, method, length);

      ReverseQueue(qu);

      Console.WriteLine("Imprime Reverse:");
      Print(qu, method, length);

      Console.WriteLine("Imprime Posições Ímpares:");
      PrintImpar(qu, true, method, length);

      Console.WriteLine("Imprime Elementos Ímpares:");
      PrintImpar(qu, false, method, length);

      Console.WriteLine("Imprime a Primeira Metade:");
      PrintHalf(qu, length, method);
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();

      for(int i=1; i<=25; i++) {
        st.Push(i);
      }

      int method = selectForOrForeach();
      int length = st.Count;

      Console.WriteLine("\nStack - {0}\n", method == 1 ? "FOR" : "FOREACH");

      Console.WriteLine("Imprime:");
      Print(st, method, length);

      ReverseStack(st);

      Console.WriteLine("Imprime Reverse:");
      Print(st, method, length);

      Console.WriteLine("Imprime Posições Ímpares:");
      PrintImpar(st, true, method, length);

      Console.WriteLine("Imprime Elementos Ímpares:");
      PrintImpar(st, false, method, length);

      Console.WriteLine("Imprime a Primeira Metade:");
      PrintHalf(st, length, method);
    }

    private static int selectForOrForeach() {
      Console.WriteLine("\n|| Selecione uma opção ||");
      Console.WriteLine("|| = = = = = = = = = = ||");
      Console.WriteLine("|| 1 - Usar For        ||");
      Console.WriteLine("|| 2 - Usar ForEach    ||");
      Console.WriteLine("|| = = = = = = = = = = ||");

      int resp = Convert.ToInt32(Console.ReadLine());

      if(resp != 1 && resp != 2) {
        Console.WriteLine("Opção Inválida.");
        selectForOrForeach();
      }

      return resp;
    }

    private static void Print(IEnumerable tad, int method, int length) {
      Console.Write("[");

      if (method == 1) {
        IEnumerator e = tad.GetEnumerator();
        for(int i=0; i<length; i++) {
          e.MoveNext();
          Console.Write(" {0}", e.Current);
        }
      } else {
        foreach(var item in tad) {
          Console.Write(" {0}", item);
        }
      }

      Console.WriteLine(" ]\n");
    }

    private static void PrintImpar(IEnumerable tad, bool key, int method, int length) {
      Console.Write("[");

      if (method == 1) {
        IEnumerator e = tad.GetEnumerator();
        for(int i=0; i<length; i++) {
          e.MoveNext();
          bool regra = (key ? i : Convert.ToInt32(e.Current)) % 2 != 0;
          if (regra)
            Console.Write(" {0}", e.Current);
        }
      } else {
        int i = 0;
        foreach(var item in tad) {
          bool regra = (key ? i : Convert.ToInt32(item)) % 2 != 0;
          if (regra)
            Console.Write(" {0}", item);
          i++;
        }
      }

      Console.WriteLine(" ]\n");
    }

    private static void PrintHalf(IEnumerable tad, int length, int method) {
      Console.Write("[");

      if (method == 1) {
        IEnumerator e = tad.GetEnumerator();
        for (int i=0; i<=length/2; i++) {
          e.MoveNext();
          Console.Write(" {0}", e.Current);
        }
      } else {
        int i = 0;
        foreach(var item in tad) {
          if (i > length/2) break;
          Console.Write(" {0}", item);
          i++;
        }
      }

      Console.WriteLine(" ]\n");
    }

    private static void ReverseQueue(Queue tad) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        tad.Enqueue(aux[i]);
      }
    }

    private static void ReverseStack(Stack tad) {
      object?[] aux = tad.ToArray();
      tad.Clear();
      for(int i=aux.Length-1; i>=0; i--) {
        tad.Push(aux[i]);
      }
    }
  }
}