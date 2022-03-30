using System;

namespace Curso04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(0,0);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro");
            }

            Console.ReadLine();
        }
    }
}
