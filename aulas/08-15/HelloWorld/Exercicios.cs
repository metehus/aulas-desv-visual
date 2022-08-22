namespace Exercicios
{
  class CalculoDeArea
  {
    public static void Start()
    {
      Console.WriteLine("Digite uma largura:");
      double largura = Convert.ToDouble(Console.ReadLine()!);

      Console.WriteLine("Digite uma altura:");
      double altura = Convert.ToDouble(Console.ReadLine()!);

      Console.WriteLine("Area: " + CalcularArea(largura, altura));
    }

    static double CalcularArea(double largura, double altura)
    {
      return largura * altura;
    }
  }

  class ConversaoMonetaria
  {
    enum Moeda
    {
      REAL,
      DOLAR,
      EURO,
      PESOS
    }
    public static void Start()
    {
      Console.WriteLine("Digite um valor em reais:");
      double real = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Valor em dólar: " + ConverteMoeda(real, Moeda.DOLAR));
      Console.WriteLine("Valor em euros: " + ConverteMoeda(real, Moeda.EURO));
      Console.WriteLine("Valor em pesos argentinos: " + ConverteMoeda(real, Moeda.PESOS));
    }

    static double ConverteMoeda(double real, Moeda moeda)
    {
      if (moeda == Moeda.REAL)
      {
        return real;
      }
      else if (moeda == Moeda.DOLAR)
      {
        return real / 5.17;
      }
      else if (moeda == Moeda.EURO)
      {
        return real / 6.14;
      }
      else if (moeda == Moeda.PESOS)
      {
        return real / 0.05;
      }
      else
      {
        return 0;
      }
    }
  }

  class IndicaMaior
  {
    public static void Start()
    {
      Console.WriteLine("Insira dois números inteiros:");
      int x = Convert.ToInt32(Console.ReadLine());
      int y = Convert.ToInt32(Console.ReadLine());

      if (x > y)
      {
        Console.WriteLine(x + " é maior e " + y + " é o menor");
      }
      else
      {
        Console.WriteLine(y + " é maior e " + x + " é o menor");
      }
    }
  }

  class ClassificaIdade
  {
    enum Classificacao
    {
      CRIANCA,
      ADOLESCENTE,
      ADULTO,
      IDOSO
    }

    public static void Start()
    {
      Console.WriteLine("Insira uma idade:");
      int idade = Convert.ToInt32(Console.ReadLine());
      var classificacao = Classifica(idade);

      Console.WriteLine("A idade de " + idade + " anos é classificada como " + classificacao);
    }

    static Classificacao Classifica(int idade)
    {
      if (idade <= 13)
      {
        return Classificacao.CRIANCA;
      }
      if (idade <= 18)
      {
        return Classificacao.ADOLESCENTE;
      }
      if (idade <= 60)
      {
        return Classificacao.ADULTO;
      }
      return Classificacao.IDOSO;
    }
  }

  class Fibonacci
  {
    public static void Start()
    {
      Console.WriteLine("Insira um valor limite");
      int limite = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("------");

      int ultimo = 1;
      int ultimo2 = 0;
      int fib = 0;

      for (int i = 0; i < limite; i++)
      {
        fib = ultimo + ultimo2;
        if (fib < limite)
        {
          ultimo2 = ultimo;
          ultimo = fib;
          Console.WriteLine(fib);
        }
        else
        {
          break;
        }
      }
    }
  }

  class Ordenacao
  {
    const int RandomMax = 2000;
    public static void Start()
    {
      int[] lista = CriarLista(1000);

      EscreverLista(lista);

      Console.WriteLine("-----");

      EscreverLista(OrdenarLista(lista));
    }

    static int[] CriarLista(int tamanho)
    {
      int[] lista = new int[tamanho];
      var random = new Random();

      for (int i = 0; i < tamanho; i++)
      {
        lista[i] = random.Next(RandomMax);
      }
      return lista;
    }

    static int[] OrdenarLista(int[] listaOriginal)
    {
      int[] lista = new int[listaOriginal.Length];

      for (int i = 0; i < listaOriginal.Length; i++)
      {
        lista[i] = listaOriginal[i];
      }

      for (int i = 0; i < listaOriginal.Length; i++)
      {
        for (int j = 0; j < listaOriginal.Length - 1; j++)
        {

          int atual = lista[j];
          int proximo = lista[j + 1];
          if (proximo > atual)
          {
            lista[j] = atual;
            lista[j + 1] = proximo;
          }
          else
          {
            lista[j] = proximo;
            lista[j + 1] = atual;
          }
        }
      }

      return lista;
    }

    static void EscreverLista(int[] lista)
    {
      string str = string.Join(",", Array.ConvertAll<int, String>(lista, Convert.ToString));
      Console.WriteLine(str);
    }
  }
}

