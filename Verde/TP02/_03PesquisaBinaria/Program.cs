using System;

namespace _03PesquisaBin {
  // Pesquisa Binária em C#: Repita a questão anterior, contudo, usando a Pesquisa Binária. A
  // entrada e a saída padrão serão iguais às da questão anterior.
  class Program {
    static void Main(string[] args) {
      Jogador[] jogadores = new Jogador[30];

      int count = PreencheArray(jogadores);

      string word = "";
      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Console.WriteLine(PesquisaBinaria(jogadores, word, count));

			} while(!word.ToUpper().Equals("FIM"));
    }

    public static int PreencheArray(Jogador[] jogadores) {
      string word = "";
      int cont = 0;

      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

          Jogador jog = new Jogador();
          jog.Ler(word);

          jogadores[cont] = jog;

          cont++;
			} while(!word.ToUpper().Equals("FIM"));
      
      return cont;
    }

    public static string PesquisaBinaria(Jogador[] jogadores, string word, int count) {
      int esq = 0, dir = count-1;

      do {
        int metade = (esq + dir) / 2;
        if (jogadores[metade].GetNome() == word) {
          return "SIM";
        } else if(String.Compare(word, jogadores[metade].GetNome()) > 0) {
          esq = metade+1;
        } else {
          dir = metade-1;
        }
      } while(esq <= dir);

      return "NAO";
    }
  }

  class Jogador {
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