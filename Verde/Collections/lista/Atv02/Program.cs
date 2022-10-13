using System;
using System.Collections;

namespace Atv02 {
	class Program {
		static void Main(string[] args) {
      // 2 - Crie um ArrayList e adicione 10 strings digitados pelo usuário. Ao final, imprima todos os elementos.
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
      for (int i=0; i<10; i++) {
        Console.WriteLine("Informe a {0}° string: ", i+1);
        al.Add(Console.ReadLine());
      }

      Console.Write("\nArrayList: [\n");
      for (int i=0; i<al.Count; i++) {
        Console.Write(" {0}\n", i==al.Count-1 ? al[i] : al[i] + ",");
      }
      Console.WriteLine("]\n");
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();
      for (int i=0; i<10; i++) {
        Console.WriteLine("Informe a {0}° string: ", i+1);
        qu.Enqueue(Console.ReadLine());
      }

      int cont = 0;
      Console.Write("\nQueue: [\n");
      foreach (object obj in qu) {
        Console.Write(" {0}\n", cont==qu.Count-1 ? obj : obj + ",");
        cont++;
      }
      Console.WriteLine("]\n");
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();
      for (int i=0; i<10; i++) {
        Console.WriteLine("Informe a {0}° string: ", i+1);
        st.Push(Console.ReadLine());
      }

      int cont = 0;
      Console.Write("\nStack: [\n");
      foreach (object obj in st) {
        Console.Write(" {0}\n", cont==st.Count-1 ? obj : obj + ",");
        cont++;
      }
      Console.WriteLine("]\n");
    }
  }
}