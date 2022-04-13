using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// Cada endereço de para uma pasta tem que ser uma posição na lista de strings 'enderecos'.

namespace TesteDeListas
{
    class Program
    {
        public void teset() { }
        static void Main(string[] args)
        {
            List<string> enderecos = new List<string>();// Cria uma lista de strings.

            Console.Write("Digite o endereço da pasta: ");
            Pastas.AdicionarEndereco(enderecos);

            Console.Write("Digite o nome da pasta: ");
            Pastas.AdicionarEndereco(enderecos);

            Console.Write("");

            Pastas.CriarPastas(enderecos);// Chamada do método 'CriarPastas' da classe 'Pastas' passando a string 'enderecos' como parâmetro.

            if (Directory.Exists(enderecos[enderecos.Count()-1]))// Verifica se alguma pasta foi criada ou se já existia alguma pasta com o nome digitado.
            {
                string resposta = "";
                string comparador = "";

                while (resposta != "s" && resposta != "n")
                {
                    Console.Write("Deseja criar subpasta? s(sim) n(não) : ");
                    resposta = Console.ReadLine();

                    switch (resposta)
                    {
                        case "s":
                            if (comparador == "")
                            {
                                Console.Write("Digite o nome da pasta: ");
                                Pastas.AdicionarEndereco(enderecos);
                                Pastas.CriarPastas(enderecos);// Chamada do método 'CriarPastas' da classe 'Pastas' passando a string 'enderecos' como parâmetro.
                                resposta = "";
                            }
                            else
                            {
                                Console.Write("Digite o nome da pasta: ");
                                Pastas.AdicionarEndereco(comparador,enderecos);
                                Pastas.CriarPastas(enderecos);// Chamada do método 'CriarPastas' da classe 'Pastas' passando a string 'enderecos' como parâmetro.
                                resposta = "";
                            }
                            break;

                        case "n":
                            string opcao = "";

                            while (opcao != "s" && opcao != "n")
                            {
                                Console.Write("Deseja voltar a alguma pastas?");
                                opcao = Console.ReadLine();

                                switch (opcao)
                                {
                                    case "s":
                                        Console.Write("Digite o enderecos: ");
                                        comparador = Console.ReadLine();
                                        int cont = 0;

                                        foreach (string obj in enderecos)
                                        {
                                            if (obj.Equals(comparador))
                                            {
                                                comparador = obj;
                                                cont++;

                                                Console.Write("\n\nOBJ-------" + obj + "--------\n\n");// Apenas para testes.
                                                Console.Write("\n\nCOMPARADOR-------" + comparador + "--------\n\n");// Apenas para testes.
                                            }                                                
                                        }
                                        if (cont == 0)
                                        {
                                            Console.WriteLine("Endereço não existe.");
                                            opcao = "";
                                        }
                                        else
                                        {
                                            resposta = "";
                                        }
                                        break;

                                    case "n":
                                        break;

                                    default:
                                        Console.Write("Digite s (sim ) ou n (não).\n");
                                        break;
                                }
                            }
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
