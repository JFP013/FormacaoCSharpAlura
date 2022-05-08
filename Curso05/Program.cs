using System;
using System.Text.RegularExpressions;

namespace Curso06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expressões regulares
            string expressao = "[0-9]{5}-?[0-9]{4}";
            string text = "Meu nome é jefferson e meu tel é 98124-3528";

            Match resultado = Regex.Match(text, expressao);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();

            //Entendendo a Substring
            string url = "www.teste.com.br/cambio/?entrada=dolar&saida=real&valor=1500";

            ExtratorValorDeArgumentoURL extrator = new ExtratorValorDeArgumentoURL(url);

            string argumento = "entrada";
            Console.WriteLine(extrator.GetValorArgumento(argumento));

            Console.ReadLine();
        }
    }
}