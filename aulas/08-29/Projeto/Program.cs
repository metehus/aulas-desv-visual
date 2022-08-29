using System;
using System.IO;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");


            bool active = true;
            while (active)
            {
                Console.WriteLine(" > Digite uma opção");
                Console.WriteLine("1: Cadastrar");
                Console.WriteLine("2: Logar");
                Console.WriteLine("3: Sair");
                try
                {
                    var option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Cadastrar();
                            break;
                        case 2:
                            Logar();
                            break;
                        case 3:
                            active = false;
                            break;
                        default:
                            Console.WriteLine(" [!] Digite uma opção válida!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" [!] Digite um valor válido");
                }
            }
        }

        static void Cadastrar()
        {
            Console.WriteLine(" * Cadastro");

            Console.WriteLine(" > Digite um nome de usuário:");
            string user = Console.ReadLine();
            string pass = "";
            
            bool confirmed = false;
            while (!confirmed) {
                Console.WriteLine(" > Digite uma senha:");
                pass = Console.ReadLine();
                Console.WriteLine(" > Confirme sua senha:");
                string confirm = Console.ReadLine();
                if (confirm == pass) {
                    confirmed = true;
                } else {
                    Console.WriteLine(" [!] As senhas não batem!");
                }
            }

            string contas = File.ReadAllText("contas.txt");

            // @todo: verificar se ja existe

        }

        static void Logar()
        {
            Console.WriteLine("Login");
        }
    }
}
