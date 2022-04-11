using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TesteDeListas
{
    class Pastas
    {
        public static void CriarPastas(List<string> pathFile)
        {
            string s = String.Join(@"\", pathFile);// Cria uma string formada pelos elementos da lista separados pelo caractere "\".

            if (Directory.Exists(s.Remove(s.LastIndexOf(@"\"))))// Verifica se o caminho onde a pasta vai ser criada existe.
            {
                if (!Directory.Exists(s))
                {
                    string nomeDaPasta;

                    nomeDaPasta = s.Substring(s.LastIndexOf(@"\") + 1);// Insere o nome da ultima pasta criada na string nomeDaPasta.

                    Directory.CreateDirectory(s);
                    Console.Write("Pasta '{0}' criada \n", nomeDaPasta);// Retorna o nome da pasta criada.
                }
                else
                {
                    Console.WriteLine("Pasta já existe. \n");
                }
            }
            else
            {
                Console.Write("Caminho não existe. \n");
            }
        }
    }
}
