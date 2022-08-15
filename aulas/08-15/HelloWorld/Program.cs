using System;
using Exercicios;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World! Aula 15-08-2022");
            
                //CalculoDeArea.Start();
                //ConversaoMonetaria.Start();
                //IndicaMaior.Start();
                //ClassificaIdade.Start();
                //Fibonacci.Start();
                Ordenacao.Start();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Insira um valor válido:");
                Console.WriteLine(erro.Message);
            }
        }
    }
}
