using System;

namespace _01Selecao {
  // Pilha com Alocação dinâmica em C#: Repita o exercício de pilha, porém, não poderáutilizar estruturas nativas, você deverá implementar as estrurutas.
	class Program {
		static void Main(string[] args) {
      Pilha pilha = new Pilha();

      InsereElementosIniciais(pilha);

      int qtdElementos = Convert.ToInt32(Console.ReadLine());

      for(int i=0; i<qtdElementos; i++) {
        string info = Console.ReadLine();
        Jogador jogador = new Jogador();

        switch(info[0]) {
          case 'I':
            jogador.Ler(info.Substring(2));
            pilha.Inserir(jogador);
            break;

          default:
            pilha.Remover();
            break;
        }
      }

      pilha.Print(pilha.topo);
    }

    public static void InsereElementosIniciais(Pilha pilha) {
      string word = "";
      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Jogador jogador = new Jogador();
        jogador.Ler(word);

        pilha.Inserir(jogador);
			} while(!word.ToUpper().Equals("FIM"));
    }
	}

  public class Celula {
	public Jogador elemento;
	public Celula prox;

	public Celula() {}

	public Celula(Jogador elemento) {
      this.elemento = elemento;
      this.prox = null;
	}
}

  public class Pilha {
	  public Celula topo;

    public Pilha() {
      this.topo = null;
    }

    public void Inserir(Jogador jogador) {
      Celula tmp = new Celula(jogador);
      tmp.prox = this.topo;
      this.topo = tmp;
      tmp = null;
    }

    public Jogador Remover() {
		  if (this.topo == null)
        throw new Exception("Lista Vazia");

      Jogador resp = this.topo.elemento;
      Celula tmp = this.topo;
      this.topo = this.topo.prox;
      tmp.prox = null;
      tmp = null;

      return resp;
    }

    public void Print(Celula i) {
      if (i != null) {
        Print(i.prox);
        i.elemento.Imprimir();
      }
    }
  }

  public class Jogador {
    private int id;
    private string nome;
    private string foto;
    private DateTime nascimento;
    private int[] times;

    public Jogador() {

    }

    public int GetId() {
      return id;
    }

    public void SetId(int id) {
      this.id = id;
    }

    public string GetNome() {
      return nome;
    }

    public void SetNome(string nome) {
      this.nome = nome;
    }

    public string GetFoto() {
      return foto;
    }

    public void SetFoto(string foto) {
      this.foto = foto;
    }

    public DateTime GetNascimento() {
      return nascimento;
    }

    public void SetNascimento(DateTime nascimento) {
      this.nascimento = nascimento;
    }

    public int[] GetTimes() {
      return times;
    }

    public void SetTimes(int[] times) {
      this.times = times;
    }

    public void Ler(string v) {
      string[] resp = v.Split('[');
      string[] dados = resp[0].Split(',');

      SetId(Convert.ToInt32(dados[5]));
      SetNome(dados[1]);
      SetFoto(dados[2]);

      string[] data = dados[3].Split('/');
      SetNascimento(new DateTime(Convert.ToInt32(data[2]), Convert.ToInt32(data[1]), Convert.ToInt32(data[0])));

      string[] timesDigitados = resp[1].Substring(0, resp[1].IndexOf("]")).Split(',');

      int[] tim = new int[timesDigitados.Length];

      for(int i=0; i<tim.Length; i++) {
        tim[i] = Convert.ToInt32(timesDigitados[i]);
      }

      SetTimes(tim);
    }

    public void Imprimir() {
      string data = GetNascimento().ToString("dd/MM/yyyy");
      string newData = data.Substring(0, 2).TrimStart('0') + data.Substring(2, data.Length-2);

      int[] t = GetTimes();
      string tim = "(";

      for(int i=0; i<t.Length; i++) {
       tim += t[i] + (i == t.Length-1 ? ")" : ", ");
      }

      Console.WriteLine("{0} {1} {2} {3} {4}", GetId(), GetNome(), newData, GetFoto(), tim);
    }
  }
}