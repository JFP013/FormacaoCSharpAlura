using System;

namespace Curso06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entendendo a Substring
            string url = "www.teste.com.br/cambio/?entrada=dolar&saida=real&valor=1500";

            ExtratorValorDeArgumentoURL extrator = new ExtratorValorDeArgumentoURL(url);

            string argumento = "entrada";
            Console.WriteLine(extrator.GetValorArgumento(argumento));

            Console.ReadLine();
        }
    }
}