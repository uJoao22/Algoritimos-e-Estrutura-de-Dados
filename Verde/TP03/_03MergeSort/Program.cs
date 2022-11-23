using System;

namespace _03MergeSort {
  // MergeSort em C#: Neste exercício você deverá ordenar os jogadores utilizando o algoritmo de MergeSort pela data de nascimento do jogador do jogador.
  // A entrada padrão é composta por várias linhas e cada uma contém dados do jogador que devem ser tratados e armazenados em objetos da classe Jogador. 
  // A última linha da entrada contém FIM. 
  // A saída padrão também contém várias linhas, uma para cada registro contido na entrada padrão, conforme o exemplo abaixo e ordenados pelo critério definido acima:
  // 42373 Diego Alves 24/06/1985 https://tmssl.akamaized.net/images/portrait/header/42373-1543845950.jpg (614, 330)

	class Program {
		static void Main(string[] args) {
      Jogador[] lista = new Jogador[20];

      string word = "";
      int i = 0;

      do {
				word = Console.ReadLine();
				if (word.ToUpper().Equals("FIM"))
					continue;

        Jogador jogador = new Jogador();
        jogador.Ler(word);
        lista[i] = jogador;
        i++;
			} while(!word.ToUpper().Equals("FIM"));

      mergeSort(lista, 0, i-1);

      foreach(Jogador item  in lista) {
        if (item != null) 
          item.Imprimir();
      }
    }

    public static void mergeSort(Jogador[] lista, int esq, int dir) {
      if (esq < dir) {
        int meio = esq + (dir-esq) / 2;
        mergeSort(lista, esq, meio);
        mergeSort(lista, meio+1, dir);
        intercalar(lista, esq, meio, dir);
      }
    }
    
    public static void intercalar(Jogador[] lista, int esq, int meio, int dir) {
      int nEsq = meio - esq + 1;
      int nDir = dir - meio;

      Jogador[] arrayEsq = new Jogador[nEsq];
      Jogador[] arrayDir = new Jogador[nDir];
      int i, j;
      
      for (i = 0; i < nEsq; ++i)
        arrayEsq[i] = lista[esq + i];

      for (j = 0; j < nDir; ++j)
        arrayDir[j] = lista[meio + 1 + j];

      i = 0;
      j = 0;
      int k = esq;

      while (i < nEsq && j < nDir) {
        if (arrayEsq[i].GetNascimento() <= arrayDir[j].GetNascimento()) {
          lista[k++] = arrayEsq[i++];
        } else {
          lista[k++] = arrayDir[j++];
        }
      }

      while (i < nEsq) {
        lista[k++] = arrayEsq[i++];
      }

      while (j < nDir) {
        lista[k++] = arrayDir[j++];
      }
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