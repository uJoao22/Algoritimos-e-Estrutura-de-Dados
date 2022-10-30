using System;

namespace _05Pilha {
  // Pilha com Alocação Sequencial em C#: Crie uma Pilha de Jogadores baseada na pilha de inteiros vista na sala de aula. 
  // A pilha pode ter tamanho 20. 
  // Neste exercício, faremos inserções, remoções e mostraremos os elementos de nossa pilha. 
  // A entrada e a saída padrão serão como as da questão anterior, contudo, teremos apenas os comandos I para inserir na pilha (empilhar) e R para remover (desempilhar).

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

      pilha.Print();
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

  public class Pilha {
    Jogador[] array;
    int count;

    public Pilha() {
      this.array = new Jogador[20];
      this.count = 0;
    }

    public void Inserir(Jogador jogador) {
      if (count >= array.Length)
        throw new Exception("Pilha Cheia");

      array[count] = jogador;
      count++;
    }

    public Jogador Remover() {
      if (count <= 0)
        throw new Exception("Pilha Vazia");

      return array[count--];
    }

    public void Print() {
      for (int i=0; i<count; i++) {
        array[i].Imprimir();
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
