using System;

namespace Curso06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entendendo a Substring
            string url = "www.teste.com.br/cambio/?entrada=dolar&saida=real";

            ExtratorValorDeArgumentoURL extrator = new ExtratorValorDeArgumentoURL(url);

            string argumento = "entrada";
            Console.WriteLine(extrator.GetValorArgumento(argumento));

            Console.ReadLine();
        }
    }
}