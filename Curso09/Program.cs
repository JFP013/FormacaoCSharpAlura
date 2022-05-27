using System;
using System.IO;
using System.Text;

namespace Curso09
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorioArquvio = "Contas.txt";

            FileStream fluxoArquivo = new FileStream(diretorioArquvio, FileMode.Open);

            byte[] buffer = new byte[1024]; //1KB
            int restanteFluxo = -1;

            while(restanteFluxo != 0)
            {
                restanteFluxo = fluxoArquivo.Read(buffer, 0, 1024);
                LerArquivoTexto(buffer);
            }
            Console.ReadLine();
        }

        static void LerArquivoTexto(byte[] buffer)
        {
            var utf8 = new UTF8Encoding();

            string texto = utf8.GetString(buffer);

            Console.Write(texto);

            //foreach (byte meuByte in buffer)
            //{
            //    Console.WriteLine(meuByte);
            //}
        }
    }
}
