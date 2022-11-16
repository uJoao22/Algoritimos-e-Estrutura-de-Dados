using System;

namespace _01Classe {
  // Suponha uma lista flexível onde os elementos estão em ordem crescente.
  // Crie os métodos de inserção e remoção desta lista, ambos recebendo o valor do elemento como parâmetro, que mantenham a lista em ordem crescente.
	class Program {
		static void Main(string[] args) {
      Celula celula = new Celula();
      celula.Insere(1);
      celula.Insere(4);
      celula.Insere(6);
      celula.Insere(9);
      celula.Insere(10);
      celula.Insere(13);
      celula.Insere(17);

      celula.mostrar();

      celula.Insere(5);
      celula.Insere(14);
      celula.Insere(22);
      celula.Insere(0);

      celula.mostrar();

      celula.Remove(0);
      celula.Remove(22);

      celula.mostrar();
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

      public void Insere(int valor) {
        if (this.elemento == null) {
          this.elemento = valor;
          this.prox = null;
          return;
        }

        if (valor < this.elemento) {
          Celula tmp = new Celula(this.elemento);
          tmp.prox = this.prox;
          this.elemento = valor;
          this.prox = tmp;
          tmp = null;
          return;
        }

        for (Celula i = this; i != null; i = i.prox) {
          if (i.prox == null || valor < i.prox.elemento) {
            Celula tmp = new Celula(valor);
            tmp.prox = i.prox;
            i.prox = tmp;
            tmp = null;
            return;
          }
        }
      }

      // Joãoo
      public Celula Remove(int valor) {
        if (valor == this.elemento) {
          Celula resp = this;
          this.elemento = this.prox.elemento;
          this.prox = this.prox.prox;
          return resp;
        }

        for (Celula i = this; i != null; i = i.prox) {
          if (i.prox != null && i.prox.elemento == valor) {
            i.prox = i.prox.prox;
            return i.prox;
          }
        }

        throw new Exception("Elemento não encontrado.");
      }

      public void mostrar() {
        Console.Write("[ ");
        for (Celula i = this; i != null; i = i.prox) {
          Console.Write(i.elemento + " ");
        }
        Console.WriteLine("]");
      }
    }
	}
}