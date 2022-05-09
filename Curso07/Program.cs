using System;

namespace Curso07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando array de conta corrente

            ContaCorrente[] ContasCorrente = new ContaCorrente[]
            {
                new ContaCorrente(123,123456),
                new ContaCorrente(123,123654),
                new ContaCorrente(123,456321)
            };
            
            for (int i = 0; i < ContasCorrente.Length; i++)
            {
                Console.WriteLine($"Agencia:{ContasCorrente[i].Agencia} ContaCorrente:{ContasCorrente[i].NumeroConta}"); 
            }

            Console.WriteLine($"O número de contas criadas é de: {ContasCorrente.Length}");
            Console.ReadLine();
        }
    }
}
