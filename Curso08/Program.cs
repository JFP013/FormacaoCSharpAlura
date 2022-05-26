using System;
using System.Collections.Generic;
using System.Linq;

namespace Curso08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<ContaCorrente> Contas = new List<ContaCorrente>()
                {
                    new ContaCorrente(10,123),
                    new ContaCorrente(1,523),
                    new ContaCorrente(9,323),
                    new ContaCorrente(4,623),
                    new ContaCorrente(8,223),
                    new ContaCorrente(1,423)
                };

                //ListarIdades();
                //ListarContasPorNumero(Contas);
                //ListarContasPorAgencia(Contas);
                ListarContasPorOderBy(Contas);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }

        static void ListarIdades()
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(12);
            idades.Add(21);
            idades.Add(31);
            idades.Add(61);

            idades.AdcionarVarios(15, 22, 34, 35, 38, 40);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void ListarContasPorNumero(List<ContaCorrente> contas)
        {  
            contas.Sort();

            foreach (ContaCorrente Conta in contas)
            {
                Console.WriteLine($"Agencia: {Conta?.Agencia} Conta Corrente: {Conta?.NumeroConta}");
            }
        }

        static void ListarContasPorAgencia(List<ContaCorrente> contas)
        {
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (ContaCorrente Conta in contas)
            {
                Console.WriteLine($"Agencia: {Conta?.Agencia} Conta Corrente: {Conta?.NumeroConta}");
            }
        }

        static void ListarContasPorOderBy(List<ContaCorrente> contas)
        {
            IEnumerable<ContaCorrente> ContasCorrente = contas.OrderBy(cc => cc.NumeroConta);

            foreach (ContaCorrente Conta in ContasCorrente)
            {
                Console.WriteLine($"Agencia: {Conta?.Agencia} Conta Corrente: {Conta?.NumeroConta}");
            }
        }
    }
}
