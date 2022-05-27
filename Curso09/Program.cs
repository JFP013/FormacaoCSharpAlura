using System;
using System.IO;
using System.Text;

namespace Curso09
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string diretorioArquvio = "Contas.txt";

            using (FileStream arquivo = new FileStream(diretorioArquvio, FileMode.Open))
            {
                using (StreamReader leitura = new StreamReader(arquivo))
                {
                    while (!leitura.EndOfStream)
                    {
                        string texto = leitura.ReadLine();
                        Console.WriteLine(texto);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
