using System;

namespace _01Classe {
  // Considerando um array A que contém n + m elementos, onde n ≫ m e os primeiros n elementos estão ordenados e os demais m elementos não estão.
  // Apresente uma solução de baixa complexidade para ordenar n + m elementos do array.
	class Program {
		static void Main(string[] args) {
      int[] array = new int[10];
      array[0] = 1;
      array[1] = 2;
      array[2] = 3;
      array[3] = 4;
      array[4] = 5;
      array[5] = 8;
      array[6] = 6;
      array[7] = 23;
      array[8] = 20;
      array[9] = 7;

      Insercao(array);

      foreach(int item in array) {
        Console.Write(item + " ");
      }
    }

    public static void Insercao(int[] array) {
      for (int i = 1; i < array.Length; i++) {
        int tmp = array[i];
        int j = i - 1;
        while ((j >= 0) && (array[j] > tmp)) {
          array[j+1] = array[j];
          j--;
        }
        array[j+1] = tmp;
      }
    }
  }
}