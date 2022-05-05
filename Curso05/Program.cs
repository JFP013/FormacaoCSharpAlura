using System;

namespace Curso05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entendendo a Substring
            string url = "pagina&Argumento";

            string argumentoUrl = url.Substring(7);

            Console.WriteLine(argumentoUrl);

            Console.ReadLine();
        }
    }
}
