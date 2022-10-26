using System;

namespace _01Classe {
  // Classe Jogadores em C#: Crie uma classe Jogadores. Sua classe terá os atributos Nome (string), Foto (string), Nascimento (Data), Id(int) e Times(Array de inteiros). Ela terá também os métodos imprimir e ler. O método imprimir mostra a string ’id nome nascimento foto (times)’, contendo todos os atributos da classe. O método ler deve efetuar a leitura dos atributos de um registro.
  // A entrada padrão é composta por várias linhas e cada uma contém dados do jogador que devem  ser tratados e armazenados em objetos da classe Jogador. A última linha da entrada contém FIM. A saída padrão também contém várias linhas, uma para cada registro contido na entrada padrão, conforme o exemplo abaixo:
	class Program {
		static void Main(string[] args) {
      string word = "";

      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Jogador jogador = new Jogador();
        jogador.Ler(word);
        jogador.Imprimir();
			} while(!word.ToUpper().Equals("FIM"));
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