using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TesteDeListas
{
    class Arquivos
    {
        public static void LerTxt (List<string> pathFile)
        {
            StreamReader lerTxt;

            Console.Write("Digite o endereço do arquivo: ");
            string enderecoTxt = Console.ReadLine();

            try
            {
                lerTxt = File.OpenText(enderecoTxt);

                while (lerTxt.EndOfStream != true)/* Enquanto nao retornar valor booleano true quer dizer que não chegou no fim do arquivo*/
                {
                    string linha = lerTxt.ReadLine();//Le conteúdo da linha

                    pathFile.Add(linha);
                }
                lerTxt.Close();/* Após sair do while, é porque leu todo o conteúdo, então fecha o arquivo texto que está aberto*/
            }
            catch (Exception)
            {
                Console.Write("\n\nProblemas ao abrir o arquivo.\n\n");
            }
        }
    }
}
