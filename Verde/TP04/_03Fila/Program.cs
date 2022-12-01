using System;

namespace _03Fila {
  // Fila com Alocação dinâmica em C#: Repita o exercício de fila, porém, não poderá utilizarestruturas nativas, você deverá implementar as estrurutas.
	class Program {
		static void Main(string[] args) {
      Fila fila = new Fila();

      InsereElementosIniciais(fila);

      int qtdElementos = Convert.ToInt32(Console.ReadLine());

      for(int i=0; i<qtdElementos; i++) {
        string info = Console.ReadLine();
        Jogador jogador = new Jogador();

        switch(info[0]) {
          case 'I':
            jogador.Ler(info.Substring(2));
            fila.Inserir(jogador);
            break;

          default:
            fila.Remover();
            break;
        }
      }

      fila.Print();
    }

    public static void InsereElementosIniciais(Fila fila) {
      string word = "";
      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Jogador jogador = new Jogador();
        jogador.Ler(word);

        fila.Inserir(jogador);
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

  public class Fila {
    public Celula primeiro;
    public Celula ultimo;

    public Fila() {
      this.primeiro = new Celula();
      this.ultimo = this.primeiro;
    }

    public void Inserir(Jogador jogador) {
      this.ultimo.prox = new Celula(jogador);
      this.ultimo = this.ultimo.prox;
    }

    public Jogador Remover() {
		  if (this.primeiro == this.ultimo)
        throw new Exception("Lista Vazia");

      Celula tmp = this.primeiro;
		  this.primeiro = this.primeiro.prox;
		  Jogador resp = this.primeiro.elemento;
      tmp.prox = null;
      tmp = null;

		  return resp;
    }

    public void Print() {
      for(Celula i = this.primeiro.prox; i != null; i = i.prox)
        i.elemento.Imprimir();
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