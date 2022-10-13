using System;
using System.Collections;

namespace roteiro {
	class Program {
		static void Main(string[] args) {
      //1. Crie o ArrayList AL1 sem definir a capacidade inicial.
      ArrayList AL1 = new ArrayList();

      // 2. Imprima a capacidade e a quantidade de elementos.
      Console.WriteLine("Capacidade: {0}, Quantidade: {1}", AL1.Capacity, AL1.Count);

      // 3. Adicione os números 19, 7 e 11.
      AL1.Add(19);
      AL1.Add(7);
      AL1.Add(11);

      // 4. Imprima a capacidade e a quantidade de elementos.
      Console.WriteLine("Capacidade: {0}, Quantidade: {1}", AL1.Capacity, AL1.Count);

      // 5. Adicione os números 5, 7 e 17.
      AL1.Add(5);
      AL1.Add(7);
      AL1.Add(17);

      // 6. Imprima a capacidade e a quantidade de elementos.
      Console.WriteLine("Capacidade: {0}, Quantidade: {1}", AL1.Capacity, AL1.Count);

      // 7. Imprima os elementos do ArrayList usando o comando foreach.
      ImprimeComForeach(AL1);

      // 8. Adicione o número 5 nas posições 0, 2 e 10. Ocorreu algum problema? Se sim,
      // anote qual foi o motivo e resolva esse problema.
      // Para inserir na posição deve ser usado Insert e não o Add, e deve ser inserido em uma posição que seja menor ou igual ao ultimo item
      AL1.Insert(0, 5);
      AL1.Insert(2, 5);
      AL1.Add(5); // Usando Add pq a posição 10 não existe

      // 9. Imprima os elementos do ArrayList usando o comando for.
      ImprimeComFor(AL1);

      // 10. Imprima a primeira e a última posição que contém o número 7.
      Console.WriteLine("Primeira posição com número sete: {0}, segunda posição: {1}", AL1.IndexOf(7), AL1.LastIndexOf(7));

      // 11. Imprima todas as posições que contém o número 5.
      Console.Write("Todas posições com número cinco: ");
      for (int i=0; i < AL1.Count; i++) {
        if (Convert.ToInt32(AL1[i]) == 5)
          Console.Write(i + " ");
      }
      Console.Write("\n");

      // 12. Adicione os números 5, 23, 47, 5 e 5.
      AL1.Add(5);
      AL1.Add(23);
      AL1.Add(47);
      AL1.Add(5);
      AL1.Add(5);

      // 13. Imprima os elementos do ArrayList usando o comando while.
      ImprimeComWhile(AL1);

      // 14. Imprima as posições do número 5 retornada pelos métodos: BinarySeach(), IndexOf() e LastIndexOf()
      Console.WriteLine("BinarySeach: {0}, IndexOf: {1}, LastIndexOf: {2}", AL1.BinarySearch(5), AL1.IndexOf(5), AL1.LastIndexOf(5));

      // 15. Ordene os elementos do ArrayList.
      AL1.Sort();

      // 16. Imprima os elementos do ArrayList (use o comando que você desejar).
      ImprimeComForeach(AL1);

      // 17. Remova o número 23.
      AL1.Remove(23);

      // 18. Imprima os elementos do ArrayList (use o comando que você desejar).
      ImprimeComFor(AL1);

      // 19. Remova o elemento da posição 7.
      AL1.RemoveAt(7);

      // 20. Imprima os elementos do ArrayList (use o comando que você desejar).
      ImprimeComWhile(AL1);

      // 21. Remova os elementos das posições 2, 3 e 4.
      AL1.RemoveAt(4);
      AL1.RemoveAt(3);
      AL1.RemoveAt(2);

      // 22. Imprima os elementos do ArrayList (use o comando que você desejar).
      ImprimeComForeach(AL1);

      // 23. Inverta os elementos do ArrayList.
      AL1.Reverse();

      // 24. Imprima os elementos do ArrayList (use o comando que você desejar).
      ImprimeComFor(AL1);

      // 25. Remova todos os elementos do ArrayList.
      AL1.Clear();

      // 26. Imprima os elementos do ArrayList (use o comando que você desejar).
      ImprimeComWhile(AL1);

      // 27. Imprima a capacidade e a quantidade de elementos.
      Console.WriteLine("Capacidade: {0}, Quantidade: {1}", AL1.Capacity, AL1.Count);
		}

    public static void ImprimeComForeach(ArrayList list) {
      Console.Write("[ ");
      foreach (int n in list) {
        Console.Write(n + " ");
      }
      Console.WriteLine("]");
    }

    public static void ImprimeComFor(ArrayList list) {
      Console.Write("[ ");
      for (int i=0; i < list.Count; i++) {
        Console.Write(list[i] + " ");
      }
      Console.WriteLine("]");
    }

    public static void ImprimeComWhile(ArrayList list) {
      int cont = 0;
      Console.Write("[ ");

      while (cont < list.Count) {
        Console.Write(list[cont] + " ");
        cont++;
      }

      Console.WriteLine("]");
    }
	}
}
