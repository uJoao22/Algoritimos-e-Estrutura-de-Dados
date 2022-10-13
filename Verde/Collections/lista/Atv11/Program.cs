using System;
using System.Collections;

namespace Atv11 {
	class Program {
		static void Main(string[] args) {
      // 11 – Faça um programa que preencha um ArrayList com elementos de diferentes tipos (int, double, float, boolean, String). Tente calcular a soma dos elementos. Evidentemente, isso irá provocar uma mensagem de erro. Que mensagem o Visual Studio retorna?
      // Dica: você pode criar um ArrayList e já inicializá-lo com alguns elementos conforme o exemplo abaixo:
      // ArrayList AL = new ArrayList() { 1, 2, "AED", new Queue(), "teste", 3.14 };
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
      ArrayList al = new ArrayList() { 1, 2.5, 10.10, true, "João" };

      var soma = 0;
      foreach(var item in al) {
        soma += Convert.ToInt32(item);
      }
      Console.WriteLine("Soma: {0}", soma);
      // ERRO: Unhandled exception. System.FormatException: Input string was not in a correct format.
    }

    public static void SoluctionOfQueuee() {
      Queue qu = new Queue();
      qu.Enqueue(1);
      qu.Enqueue(1.5);
      qu.Enqueue(10.10);
      qu.Enqueue(true);
      qu.Enqueue("João");

      var soma = 0;
      foreach(var item in qu) {
        soma += Convert.ToInt32(item);
      }
      Console.WriteLine("Soma: {0}", soma);
      // ERRO: Unhandled exception. System.FormatException: Input string was not in a correct format.
    }

    public static void SoluctionOfStack() {
      Stack st = new Stack();
      st.Push(1);
      st.Push(1.5);
      st.Push(10.10);
      st.Push(true);
      st.Push("João");

      var soma = 0;
      foreach(var item in st) {
        soma += Convert.ToInt32(item);
      }
      Console.WriteLine("Soma: {0}", soma);
      // ERRO: Unhandled exception. System.FormatException: Input string was not in a correct format.
    }
  }
}