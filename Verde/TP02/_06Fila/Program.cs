using System;

namespace _06Fila {
  // Fila Circular com Alocação Sequencial em C#: Crie uma classe Fila Circular de Jogadores.
  // Essa fila deve ter tamanho cinco. 
  // Em seguida, façaa um programa que leia vários registros e insira seus atributos na fila. 
  // Quando o programa tiver que inserir um objeto e a fila estiver cheia, antes, ele deve fazer uma remoção. 
  // A entrada e a saída padrão serão como as da questão anterior.

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

  public class Fila {
    Jogador[] array;
    int primeiro;
    int ultimo;

    public Fila() {
      this.array = new Jogador[6+1];
      this.primeiro = 0; 
      this.ultimo = 0;
    }

    public void Inserir(Jogador jogador) {
      if (((ultimo+1) % array.Length) == primeiro)
        throw new Exception("Fila Cheia");

      array[ultimo] = jogador;
      ultimo = (ultimo+1) % array.Length;
    }

    public Jogador Remover() {
      if (primeiro == ultimo)
        throw new Exception("Fila Vazia");

      Jogador resp = array[primeiro];
      primeiro = (primeiro+1) % array.Length;
      return resp;
    }

    public void Print() {
      int i = primeiro;
      while(i != ultimo) {
        array[i].Imprimir();
        i = (i+1) % array.Length;
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
