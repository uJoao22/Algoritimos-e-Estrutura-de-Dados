using System;

namespace _01Selecao {
  // Lista com Alocação dinâmica em C#: Repita o exercício de lista, porém, não poderá utilizarestruturas nativas, você deverá implementar as estrurutas.
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

  public class Celula {
    public Jogador elemento;
    public Celula prox;
    public Celula() {}

    public Celula(Jogador x) {
      this.elemento = x;
      this.prox = null;
    }
  }

  public class Lista {
    public Celula primeiro;
    public Celula ultimo;

    public Lista() {
      this.primeiro = new Celula();
      this.ultimo = this.primeiro;
    }

    public void InserirInicio(Jogador jogador) {
      Celula tmp = new Celula(jogador);
      tmp.prox = this.primeiro.prox;
		  this.primeiro.prox = tmp;
		  if (this.primeiro == this.ultimo) {                 
			  this.ultimo = tmp;
		  }
      tmp = null;
    }

    public void InserirFim(Jogador jogador) {
      this.ultimo.prox = new Celula(jogador);
      this.ultimo = this.ultimo.prox;
    }

    public void Inserir(Jogador jogador, int pos) {
      int length = Length();

      if(pos < 0 || pos > length)
			  throw new Exception("Posição invalida!");
      
      if (pos == 0){
        InserirInicio(jogador);
      } else if (pos == length) {
         InserirFim(jogador);
      } else {
         Celula i = this.primeiro;
         for(int j = 0; j < pos; j++, i = i.prox);
		
         Celula tmp = new Celula(jogador);
         tmp.prox = i.prox;
         i.prox = tmp;
         i = null;
         tmp = null;
      }
    }

    public Jogador RemoverInicio() {
		  if (this.primeiro == this.ultimo)
        throw new Exception("Lista Vazia");

      Celula tmp = this.primeiro;
      this.primeiro = this.primeiro.prox;
      Jogador resp = this.primeiro.elemento;
      tmp.prox = null;
      tmp = null;

      return resp;
    }

    public Jogador RemoverFim() {
      if (primeiro == ultimo)
        throw new Exception("Lista Vazia");

      Celula i;
      for(i = this.primeiro; i.prox != this.ultimo; i = i.prox);

      Jogador resp = this.ultimo.elemento; 
      this.ultimo = i; 
      this.ultimo.prox = null;
      i = null;
        
      return resp;
    }

    public Jogador Remover(int pos) {
      Jogador resp;
      int length = Length();

      if (primeiro == ultimo)
        throw new Exception("Lista Vazia");

       if(pos < 0 || pos >= length)
        throw new Exception("Posição invalida!");
      
      if (pos == 0) {
        resp = RemoverInicio();
      } else if (pos == length - 1){
        resp = RemoverFim();
      } else {
        Celula i = this.primeiro;
        for(int j = 0; j < pos; j++, i = i.prox);
    
        Celula tmp = i.prox;
        resp = tmp.elemento;
        i.prox = tmp.prox;
        tmp.prox = null;
        tmp = null;
        i = null;
      }

      return resp;
    }

    public int Length() {
      int length = 0; 
      for(Celula i = this.primeiro; i != this.ultimo; i = i.prox, length++);
      return length;
   }

    public void Print() {
      for(Celula i = this.primeiro.prox; i != null; i = i.prox) {
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