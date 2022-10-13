using System;
using System.Collections;

namespace Atv08_09_10 {
	class Program {
		static void Main(string[] args) {
      // 8 - Faça um programa que leia n números inteiros e os armazene em um ArrayList. Calcule a soma e a média aritmética (use o comando FOR e depois o FOREACH).
      // 9 – Faça um programa que leia n números inteiros e os armazene em um Queue. Calcule a soma e a média aritmética (use o comando FOREACH para iterar sobre os elementos).
      // 10 – Faça um programa que leia n números inteiros e os armazene em um Stack. Calcule a soma e a média aritmética (use o comando FOREACH para iterar sobre os elementos).
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
          Console.WriteLine("Quantos números serão inseridos:");
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

      for(int i=0; i<n; i++) {
        Console.WriteLine("Insira o {0}° número inteiro:", i+1);
        al.Add(Convert.ToInt32(Console.ReadLine()));
      }

      int method = selectForOrForeach();
      int soma = 0;

      if (method == 1) {
        for(int i=0; i<al.Count; i++) {
          soma += Convert.ToInt32(al[i]);
        }
      } else {
        foreach(int num in al) {
          soma += num;
        }
      }
      Console.WriteLine((method == 1 ? "FOR" : "FOREACH") + " - Soma: {0}, Média: {1}\n", soma, soma/al.Count);
    }

    public static void SoluctionOfQueuee(int n) {
      Queue qu = new Queue();

      for(int i=0; i<n; i++) {
        Console.WriteLine("Insira o {0}° número inteiro:", i+1);
        qu.Enqueue(Convert.ToInt32(Console.ReadLine()));
      }

      int method = selectForOrForeach();
      int soma = 0;
      int length = qu.Count;

      if (method == 1) {
        for(int i=0; i<length; i++) {
          soma += Convert.ToInt32(qu.Dequeue());
        }
      } else {
        foreach(object obj in qu) {
          soma += Convert.ToInt32(obj);
        }
      }
      Console.WriteLine((method == 1 ? "FOR" : "FOREACH") + " - Soma: {0}, Média: {1}\n", soma, soma/length);
    }

    public static void SoluctionOfStack(int n) {
      Stack st = new Stack();

      for(int i=0; i<n; i++) {
        Console.WriteLine("Insira o {0}° número inteiro:", i+1);
        st.Push(Convert.ToInt32(Console.ReadLine()));
      }

      int method = selectForOrForeach();
      int soma = 0;
      int length = st.Count;

      if (method == 1) {
        for(int i=0; i<length; i++) {
          soma += Convert.ToInt32(st.Pop());
        }
      } else {
        foreach(object obj in st) {
          soma += Convert.ToInt32(obj);
        }
      }
      Console.WriteLine((method == 1 ? "FOR" : "FOREACH") + " - Soma: {0}, Média: {1}\n", soma, soma/length);
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
  }
}