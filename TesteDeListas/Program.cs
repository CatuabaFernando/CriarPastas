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
        public void teset() { }
        static void Main(string[] args)
        {
            List<string> enderecos = new List<string>();// Cria uma lista de strings.
            string modelo = "";

            while (modelo != "s" && modelo != "n")
            {
                Console.Write("Deseja usar um modelo existente? s(sim) n(não) : ");
                modelo = Console.ReadLine();

                switch (modelo)
                {
                    case "s":

                        // ESSA PARTE DO CODIGO ESTAVA FUNCIOANDO NÃO APAGAR.
                        /*Arquivos.LerTxt(enderecos);// Adiciona os endereços contidos no txt selecionado na lista 'endereços'.
                        Pastas.CriarPastas(enderecos);//Cria as pastas nos endereços contidos na lista e'endereços'.*/


                        string[] teste = 
                            {
                                @"C:\PASTA",
                                @"C:\PASTA\INSIRA_O_NOME",
                                @"C:\PASTA\INSIRA_O_NOME\PROGRAMA",
                                @"C:\PASTA\INSIRA_O_NOME\DESENHO",
                                @"C:\PASTA\INSIRA_O_NOME\DESENHO\3D"
                            };



                        string[] arquivos = Directory.GetFiles(@"C:\PASTA", "*.xlsx");// Retornar apenas arquivos com a extensão selecionada.           

                        foreach (string obj in arquivos)
                        {
                            Console.Write("--> " + Path.GetFileNameWithoutExtension(obj) + "\n");

                            foreach (string item in teste)
                            {
                                string s = item.Replace("INSIRA_O_NOME", Path.GetFileNameWithoutExtension(obj));
                                Console.Write("--> " + s + "\n");

                                enderecos.Add(s);
                            }
                        }

                        Pastas.CriarPastas(enderecos);

                        foreach (string obj in arquivos)
                        {
                            File.Move(obj, @"C:\PASTA\" + Path.GetFileNameWithoutExtension(obj) + @"\DESENHO\3D\" + Path.GetFileName(obj));// Move o arquivos  
                        }

                        Console.Write("\n Digite qualquer coisa para sair.");

                        Console.ReadKey();
                        break;

                    case "n":
                        /*Console.Write("Digite o endereço da pasta: ");
                        Pastas.AdicionarEndereco(enderecos);

                        Console.Write("Digite o nome da pasta: ");
                        Pastas.AdicionarEndereco(enderecos);

                        Console.Write("");// Pular linha.

                        Pastas.CriarPastas(enderecos);// Chamada do método 'CriarPastas' da classe 'Pastas' passando a string 'enderecos' como parâmetro.

                        if (Directory.Exists(enderecos[enderecos.Count() - 1]))// Verifica se alguma pasta foi criada ou se já existia alguma pasta com o nome digitado.
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
                                            Pastas.AdicionarEndereco(comparador, enderecos);
                                            Pastas.CriarPastas(enderecos);// Chamada do método 'CriarPastas' da classe 'Pastas' passando a string 'enderecos' como parâmetro.
                                            resposta = "";
                                        }
                                        break;

                                    case "n":
                                        string opcao = "";

                                        while (opcao != "s" && opcao != "n")
                                        {
                                            Console.Write("Deseja voltar a alguma pasta? s(sim) n(não)");
                                            opcao = Console.ReadLine();

                                            switch (opcao)
                                            {
                                                case "s":
                                                    Console.Write("Digite o endereço: ");
                                                    comparador = Console.ReadLine();
                                                    int cont = 0;

                                                    foreach (string obj in enderecos)
                                                    {
                                                        if (obj.Equals(comparador))
                                                        {
                                                            comparador = obj;
                                                            cont++;
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
                        }*/
                        Console.Write("\n Digite qualquer coisa para sair.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("Digite s (sim ) ou n (não).\n");
                        break;
                }
            }
        }
    }
}
