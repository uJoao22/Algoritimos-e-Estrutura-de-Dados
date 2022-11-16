using System;

namespace _01Classe {
  // Seja nossa classe Pilha Flexível, faça um método R.E.C.U.R.S.I.V.O que recebe dois objetos do tipo Pilha e mostra na tela os elementos contidos nessas Pilhas de forma intercalada.
	class Program {
		static void Main(string[] args) {
      Pilha p1 = new Pilha();
      Pilha p2 = new Pilha();

      // pilha.Separar(f1, f2);

      p1.Insere(1);
      p1.Insere(4);
      p1.Insere(6);
      p1.Insere(9);

      p2.Insere(10);
      p2.Insere(13);
      p2.Insere(17);
      p2.Insere(22);

      Pilha pilha = new Pilha();
      pilha.Intercala(p1, p2);
    }

    class Pilha {
      public Celula topo;

      public Pilha() {
        this.topo = null;
      }

      public void Imprimir() {
        Console.Write("[ ");
        for(Celula i = topo; i != null; i = i.prox) {
          Console.Write(i.elemento + " ");
        }
        Console.WriteLine("]");
      }

      public void Insere(int x) {
        Celula tmp = new Celula(x);
        tmp.prox = topo;
        topo = tmp;
        tmp = null;
      }

      public void Intercala(Pilha p1, Pilha p2) {
        Intercala(p1.topo, p2.topo, 1);
      }

      private void Intercala(Celula p1, Celula p2, int chave) {
        bool condicao = p1 == null && p2 == null;
        if (condicao)
          return;

        if (chave % 2 == 0) {
          Console.WriteLine(p2.elemento);
          Intercala(p1, p2.prox, (condicao ? -1 : chave+1));
        } else {
          Console.WriteLine(p1.elemento);
          Intercala(p1.prox, p2, (condicao ? -1 : chave+1));
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