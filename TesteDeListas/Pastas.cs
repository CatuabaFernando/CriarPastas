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
            if (Directory.Exists(pathFile[0]))
            {
                foreach (string s in pathFile)
                {
                    if (!Directory.Exists(s))
                    {
                        string nomeDaPasta;

                        nomeDaPasta = s.Substring(s.LastIndexOf(@"\") + 1);// Insere o nome da ultima pasta criada na string nomeDaPasta.

                        Console.Write("\n\nO endereço da nova pasta é: " + s + "\n\n");
                        Directory.CreateDirectory(s);
                        Console.Write("Pasta '{0}' criada \n", nomeDaPasta);// Retorna o nome da pasta criada.
                    }
                }
            }
            else
            {
                Console.Write("\n\nCaminho não existe\n\n");
            }
        }

        public static void AdicionarEndereco(List<string> pathFile)
        {
            if (pathFile.Count == 0)
            {
                pathFile.Add(Console.ReadLine());
            }
            else
            {
                string s = String.Empty;

                foreach (string obj in pathFile)
                {
                    s += obj;
                }

                pathFile.Add(s + @"\" + Console.ReadLine());
            }
        }
    }
}
