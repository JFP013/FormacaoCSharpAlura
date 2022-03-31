using System;

namespace Curso04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(1,2);
               
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
                Console.WriteLine("para Programadores:");
                Console.WriteLine("Exception do tipo SaldoInsuficienteException");
                Console.WriteLine(ex.StackTrace);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
                Console.WriteLine("para Programadores:");
                Console.WriteLine("Exception do tipo ArgumentException");
                Console.WriteLine("O argumento com problema é o " + ex.ParamName);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine("");
                Console.WriteLine("para Programadores:");
                Console.WriteLine("Exception do tipo Exception");
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
