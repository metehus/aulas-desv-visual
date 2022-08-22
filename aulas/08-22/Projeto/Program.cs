using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Calcular números! Aula 2-08-2022");
      Console.WriteLine("Digite os números separado por ,");

      string[] split = Console.ReadLine()!.Split(",");
      double[] valores = new double[split.Length];

      for (int i = 0; i < split.Length; i++)
      {
        valores[i] = Convert.ToDouble(split[i]);
      }

      Console.WriteLine("Média: " + CalculaMedia(valores));
      Console.WriteLine("Mediana: " + CalculaMediana(valores));
      Console.WriteLine("Moda 1:  " + CalculaModa1(valores));
      Console.WriteLine("Moda2 2: " + EscreverLista(CalculaModa2(valores)));

    }

    static string EscreverLista(double[] lista)
    {
      return string.Join(",", Array.ConvertAll<double, String>(lista, Convert.ToString));
    }

    static string EscreverLista(int[] lista)
    {
      return string.Join(",", Array.ConvertAll<int, String>(lista, Convert.ToString));
    }

    static double CalculaMedia(double[] valores)
    {
      double soma = 0;

      for (int i = 0; i < valores.Length; i++)
      {
        soma += valores[i];
      }

      return soma / valores.Length;
    }

    static double CalculaMediana(double[] valores)
    {
      Array.Sort(valores);
      int quantidade = valores.Length;

      if (valores.Length % 2 == 0)
      {
        double[] medianos = { valores[quantidade / 2], valores[quantidade / 2 + 1] };

        return CalculaMedia(medianos);
      }
      else
      {
        return valores[(int)(valores.Length / 2 - 0.5)];
      }
    }

    static double CalculaModa1(double[] valores)
    {
      double selecionado = 0;
      int quantidadeSelecionado = 0;

      for (int i = 0; i < valores.Length; i++)
      {
        double valor = valores[i];
        int quantidadeValor = 0;
        for (int j = 0; j < valores.Length; j++)
        {
          if (valor == valores[j])
          {
            quantidadeValor++;
          }
        }
        if (quantidadeValor > quantidadeSelecionado)
        {
          quantidadeSelecionado = quantidadeValor;
          selecionado = valor;
        }
      }

      return selecionado;
    }

    static double[] CalculaModa2(double[] valores)
    {
      int[] quantidades = new int[valores.Length];
      int quantidadeMaior = 0;

      for (int i = 0; i < valores.Length; i++)
      {
        double valor = valores[i];
        int quantidadeValor = 0;
        for (int j = 0; j < valores.Length; j++)
        {
          if (valor == valores[j])
          {
            quantidadeValor++;
          }
        }
        quantidades[i] = quantidadeValor;
        if (quantidadeValor > quantidadeMaior)
        {
          quantidadeMaior = quantidadeValor;
        }
      }


      int medianasEncontradas = 0;
      double[] medianas = new double[valores.Length];

      for (int i = 0; i < valores.Length; i++)
      {
        double valor = valores[i];
        int quantidade = quantidades[i];

        bool encontrado = false;
        for (int j = 0; j < medianas.Length; j++)
        {
          if (medianas[j] == valor)
          {
            encontrado = true;
            break;
          }
        }
        if (encontrado) continue;


        if (quantidade == quantidadeMaior)
        {
          medianas[medianasEncontradas++] = valor;
        }
      }

      double[] medianasFinal = new double[medianasEncontradas];

      for (int i = 0; i < medianasFinal.Length; i++)
      {
        medianasFinal[i] = medianas[i];
      }


      return medianasFinal;
    }
  }
}
