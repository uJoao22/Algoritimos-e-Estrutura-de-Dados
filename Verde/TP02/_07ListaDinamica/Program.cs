using System;
using System.Collections;

namespace _07ListaDinamica {
  // Lista com Alocação dinâmica em C#: Repita o exercício de lista, porém utilizando estruturas nativas (collections).
  class Program {
    static void Main(string[] args) {
      ArrayList lista = new ArrayList(20);
      
      InsereElementosIniciais(lista);

      int qtdElementos = Convert.ToInt32(Console.ReadLine());

      for(int i=0; i<qtdElementos; i++) {
        string info = Console.ReadLine();
        Jogador jogador = new Jogador();

        switch(info.Substring(0, 2)) {
          case "II":
            jogador.Ler(info.Substring(3));
            lista.Insert(0, jogador);
            break;

          case "IF":
            jogador.Ler(info.Substring(3));
            lista.Add(jogador);
            break;

          case "I*":
            string elemento =info.Substring(3);
            jogador.Ler(elemento);
            int pos = Convert.ToInt32(elemento.Substring(0, 2).Replace(" ", ""));
            lista.Insert(pos, jogador);
            break;

          case "RI":
            lista.RemoveAt(0);
            break;

          case "RF":
            lista.RemoveAt(lista.Count-1);
            break;

          default:
            lista.RemoveAt(Convert.ToInt32(info.Substring(3).Replace(" ", "")));
            break;
        }
      }

      foreach (Jogador item in lista) {
        item.Imprimir();
      }
    }

    public static void InsereElementosIniciais(ArrayList lista) {
      string word = "";
      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Jogador jogador = new Jogador();
        jogador.Ler(word);
        lista.Add(jogador);
			} while(!word.ToUpper().Equals("FIM"));
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
