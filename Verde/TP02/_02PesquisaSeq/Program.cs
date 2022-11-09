using System;

namespace _02PesquisaSeq {
  // Pesquisa Sequencial em C#: Faça a inserção de alguns objetos no final de uma Lista e, em seguida, faça algumas pesquisas sequenciais. 
  // A chave primária de pesquisa será o atributo nome  do jogador. 
  // A entrada padrão é composta por duas partes onde a primeira é igual a entrada da primeira questão 1. 
  // As demais linhas correspondem a segunda parte. A segunda parte é composta por várias linhas. 
  // Cada uma possui um elemento que deve ser pesquisado na Lista.
  // A última linha terá a palavra FIM. 
  // A saída padrão será composta por várias linhas contendo as palavras SIM/NAO para indicar se existe cada um dos elementos pesquisados.
  class Program {
    static void Main(string[] args) {
      Jogador[] jogadores = new Jogador[30];

      int count = PreencheArray(jogadores);

      string word = "";
      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Console.WriteLine(PesquisaSequencial(jogadores, word, count));

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

    public static string PesquisaSequencial(Jogador[] jogadores, string word, int count) {
      for(int i=0; i<count; i++) {
        if (jogadores[i].GetNome() == word) {
          return "SIM";
        }
      }
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