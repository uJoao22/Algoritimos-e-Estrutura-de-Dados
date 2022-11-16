using System;

namespace _01Classe {
  // Considere a classe Fila Flexível de inteiros vista na sala de aula.
  // Crie o método void separar(Fila f1, Fila f2) que recebe dois objetos do tipo Fila f1 e f2 e copia todos os números ímpares da Fila corrente para f1 e os pares para f2. Seu método não pode utilizar os métodos de inserir e remover existentes na fila.
	class Program {
		static void Main(string[] args) {
      Fila fila = new Fila();

      Fila f1 = new Fila();
      Fila f2 = new Fila();

      // fila.Separar(f1, f2);

      fila.Insere(1);
      fila.Insere(4);
      fila.Insere(6);
      fila.Insere(9);
      fila.Insere(10);
      fila.Insere(13);
      fila.Insere(17);
      fila.Insere(22);

      fila.Separar(f1, f2);

      f1.Imprimir();
      f2.Imprimir();
    }

    class Fila {
      public Celula primeiro, ultimo;

      public Fila () {
        primeiro = new Celula();
        ultimo = primeiro;
      }

      public void Insere(int x) {
        ultimo.prox = new Celula(x);
        ultimo = ultimo.prox;
      }

      public int Remove() {
        if (primeiro == ultimo)
          throw new Exception("Fila Vazia");

        Celula tmp = primeiro;
        primeiro = primeiro.prox;
        int elemento = primeiro.elemento;
        tmp.prox = null;
        tmp = null;
        return elemento;
      }

      public void Imprimir() {
        Console.Write("[ ");
        for(Celula i = primeiro.prox; i != null; i = i.prox) {
          Console.Write(i.elemento + " ");
        }
        Console.WriteLine("]");
      }

      public void Separar(Fila f1, Fila f2) {
        if (primeiro == ultimo)
          throw new Exception("Fila Vazia");

        for(Celula i = primeiro.prox; i != null; i = i.prox) {
          if (i.elemento % 2 == 0) {
            f2.ultimo.prox = new Celula(i.elemento);
            f2.ultimo = f2.ultimo.prox;
          } else {
            f1.ultimo.prox = new Celula(i.elemento);
            f1.ultimo = f1.ultimo.prox;
          }
        }
      }
    }

    class Celula {
      public int elemento;
      public Celula prox;

      public Celula() {

      }

      public Celula(int x) {
        this.elemento = x;
        this.prox = null;
      }
    }
	}
}