using System;

namespace _04Lista {
  // Lista com Alocação Sequencial em C#: Crie uma Lista de Jogadores baseada na lista de inteiros vista na sala de aula. 
  // A lista pode ter tamanho 20. Sua lista deve conter todos os atributos e métodos existentes na lista de inteiros, contudo, adaptados para a classe Jogador. 
  // De toda forma, lembre-se que, na verdade, temos uma lista de ponteiros e cada um deles aponta para um objeto Jogador. 
  // Neste exercício, faremos inserções, remoções e mostraremos os elementos de nossa lista. 
  // Os métodos de inserir e remover devem operar conforme descrito a seguir, respeitando parâmetros e retornos. 
  // Primeiro, o void inserirInicio(Jogador jogador) insere um objeto na primeira posição da Lista e remaneja os demais. 
  // Segundo, o void inserir(Jogador jogador, int posição) insere um objeto na posição p da Lista, onde p < n e n é o número de objetos cadastrados. 
  //Em seguida, esse método remaneja os demais objetos. 
  // O void inserirFim(Jogador jogador) insere um objeto na última posição da Lista. 
  // O método removerInicio() remove e retorna o primeiro objeto cadastrado na Lista e remaneja os demais. 
  // O método remover(int posição) remove e retorna o objeto cadastrado na p-ésima posição da Lista e remaneja os demais. 
  // O método removerFim() remove e retorna o ultimo objeto cadastrado na Lista. 
  // A entrada padrão é composta por duas partes. 
  // A primeira é igual a entrada da primeira questão. 
  // As demais linhas correspondem a segunda parte. 
  // A primeira linha da segunda parte tem um número inteiro n indicando a quantidade de objetos a serem inseridos/removidos. 
  // Nas próximas n linhas, tem-se n comandos de inserção/remoção a serem processados neste exercício. 
  // Cada uma dessas linhas tem uma palavra de comando: II inserir no início, I* inserir em qualquer posição, IF inserir no fim, RI remover no início, R* remover em qualquer posição e RF remover no fim. 
  // No caso dos comandos de inserir, temos também o id do registro a ser inserido. 
  // No caso dos comandos de “em qualquer posição”, temos também a posição.
  // No Inserir, a posição fica imediatamente após a palavra de comando.
  // A saída padrão tem uma linha para cada objeto removido sendo que essa informação será constituída pela palavra “(R)” e o atributo nome. 
  // No final, a saída mostra os atributos relativos a cada objeto cadastrado na lista após as operações de inserção e remoção.

  class Program {
    static void Main(string[] args) {
      Lista lista = new Lista();
      
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

    public static void InsereElementosIniciais(Lista lista) {
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

  public class Lista {
    Jogador[] array;
    int count;

    public Lista() {
      this.array = new Jogador[20];
      this.count = 0;
    }

    public void InserirInicio(Jogador jogador) {
      if (count >= array.Length)
        throw new Exception("Lista Cheia");

      for(int i=count; i>0; i--)
        array[i] = array[i-1];

      array[0] = jogador;
      count++;
    }

    public void InserirFim(Jogador jogador) {
      if (count >= array.Length)
        throw new Exception("Lista Cheia");

      array[count] = jogador;
      count++;
    }

    public void Inserir(Jogador jogador, int pos) {
      if (count >= array.Length)
        throw new Exception("Lista Cheia");

      if(pos < 0 || pos > count)
        throw new Exception("Posição Inválida");

      for(int i=count; i>pos; i--)
        array[i] = array[i-1];

      array[pos] = jogador;
      count++;
    }

    public Jogador RemoverInicio() {
      if (count <= 0)
        throw new Exception("Lista Vazia");

      Jogador resp = array[0];
      count--;

      for(int i=0; i<count; i++)
        array[i] = array[i+1];
      
      return resp;
    }

    public Jogador RemoverFim() {
      if (count <= 0)
        throw new Exception("Lista Vazia");

      return array[count--];
    }

    public Jogador Remover(int pos) {
      if (count <= 0)
        throw new Exception("Lista Vazia");

      if(pos < 0 || pos >= count)
        throw new Exception("Posição Inválida");

      Jogador resp = array[pos];
      count--;

      for(int i=pos; i<count; i++)
        array[i] = array[i+1];

      return resp;
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
