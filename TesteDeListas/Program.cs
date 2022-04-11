using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TesteDeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> caminho = new List<string>();// Cria uma lista de strings.

            Console.Write("Digite o caminho da pasta: ");

            caminho.Add(Console.ReadLine());

            Console.Write("Digite o nome da pasta: ");

            caminho.Add(Console.ReadLine());

            Console.Write("");

            Pastas.CriarPastas(caminho);// Chamada do método CreateFiles da classe CriarPastas passando a string s como parâmetro.

            if (Directory.Exists(String.Join(@"\", caminho)))// Verifica se alguma pasta foi criada ou se já existia alguma pasta com o nome digitado.
            {
                string resposta = "";

                while (resposta != "s" && resposta != "n")
                {
                    Console.Write("Deseja crirar subpasta? s(sim) n(não) : ");
                    resposta = Console.ReadLine();

                    switch (resposta)
                    {
                        case "s":
                            Console.Write("Digite o nome da pasta: ");
                            caminho.Add(Console.ReadLine());
                            Pastas.CriarPastas(caminho);// Chamada do método CreateFiles da classe CriarPastas passando a string s como parâmetro.
                            resposta = "";
                            break;

                        case "n":
                            break;

                        default:
                            Console.Write("Digite s (sim ) ou n (não).\n");
                            break;
                    }
                }
            }
            Console.Write("\n Digite qualquer coisa para sair.");
            Console.ReadKey();
        }
    }
}
