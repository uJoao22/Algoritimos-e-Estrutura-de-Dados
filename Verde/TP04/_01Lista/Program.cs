using System;

namespace _01Selecao {
  // Lista com Alocação dinâmica em C#: Repita o exercício de lista, porém, não poderá utilizarestruturas nativas, você deverá implementar as estrurutas.
	class Program {
		static void Main(string[] args) {
      Celula lista = new Celula();

      InsereElementosIniciais(lista);

      int qtdElementos = Convert.ToInt32(Console.ReadLine());

      for(int i=0; i<qtdElementos; i++) {
        string info = Console.ReadLine();
        Jogador jogador = new Jogador();

        switch(info.Substring(0, 2)) {
          case "II":
            jogador.Ler(info.Substring(3));
            lista.InserirInicio(jogador);
            break;

          case "IF":
            jogador.Ler(info.Substring(3));
            lista.InserirFim(jogador);
            break;

          case "I*":
            string elemento =info.Substring(3);
            jogador.Ler(elemento);
            int pos = Convert.ToInt32(elemento.Substring(0, 2).Replace(" ", ""));
            lista.Inserir(jogador, pos);
            break;

          case "RI":
            lista.RemoverInicio();
            break;

          case "RF":
            lista.RemoverFim();
            break;

          default:
            lista.Remover(Convert.ToInt32(info.Substring(3).Replace(" ", "")));
            break;
        }
      }

      lista.Print();
    }

    public static void InsereElementosIniciais(Celula lista) {
      string word = "";
      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Jogador jogador = new Jogador();
        jogador.Ler(word);

        lista.InserirFim(jogador);
			} while(!word.ToUpper().Equals("FIM"));
    }
	}

  public class Celula {
    public Jogador elemento;
    public Celula prox;

    public Celula() {
    }

    public Celula(Jogador x) {
      this.elemento = x;
      this.prox = null;
    }

    public void InserirInicio(Jogador jogador) {
      Celula tmp = new Celula(this.elemento);
      tmp.prox = this.prox;
      this.elemento = jogador;
      this.prox = tmp;
      tmp = null;
    }

    public void InserirFim(Jogador jogador) {
      if (this.elemento == null) {
        this.elemento = jogador;
        this.prox = null;
      } else {
        for(Celula i = this; i != null; i = i.prox) {
          if (i.prox == null)
            i.prox = new Celula(jogador);
        }
      }
    }

    public void Inserir(Jogador jogador, int pos) {
      if (pos == 0 && this.elemento == null) {
        this.elemento = jogador;
        return;
      } else {
        int cont = 1;
        for(Celula i = this.prox; i != null; i = i.prox) {
          if (cont == pos) {
            Celula tmp = i.prox;
            i.elemento = jogador;
            i.prox = tmp;
            tmp = null;
            return;
          }

          cont++;
        }
      }

      throw new Exception("Posição Inválida");
    }

    public Jogador RemoverInicio() {
      if (this.elemento == null)
        throw new Exception("Lista Vazia");

      Jogador resp = this.elemento;
      this.elemento = this.prox.elemento;
      this.prox = this.prox.prox;
      return resp;
    }

    public Jogador RemoverFim() {
      if (this.elemento == null)
        throw new Exception("Lista Vazia");

      for(Celula i = this; i != null; i = i.prox) {
        if (i.prox == null) {
          Jogador resp = i.elemento;
          i = null;
          return resp;
        }
      }

      throw new Exception("Não é possível remover.");
    }

    public Jogador Remover(int pos) {
      if (this.elemento == null)
        throw new Exception("Lista Vazia");

      int cont = 0;
      for(Celula i = this; i != null; i = i.prox) {
        if (cont == pos) {
          Jogador resp = i.elemento;
          i.elemento = i.prox.elemento;
          i.prox = i.prox.prox;
          return resp;
        }

        cont++;
      }

      throw new Exception("Não é possível remover.");
    }

    public void Print() {
      for(Celula i = this; i != null; i = i.prox) {
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