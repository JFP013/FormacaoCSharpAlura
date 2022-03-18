using System;

namespace Curso02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as ContasCorrente e atribuindo o titular
            ContaCorrente conta1 = new ContaCorrente(123, 123456);
            conta1.Titular = new Cliente();

            conta1.Titular.Nome = "Jefferson";

            ContaCorrente conta2 = new ContaCorrente(321, 654321);
            conta2.Titular = new Cliente();

            conta2.Titular.Nome = "Camila";

            //Tentar Sacar 100 com o Saldo 0
            conta1.Sacar(100);
            Console.WriteLine("O Saldo do titular " + conta1.Titular.Nome + " é de " + conta1.Saldo);

            conta2.Sacar(100);
            Console.WriteLine("O Saldo do titular " + conta2.Titular.Nome + " é de " + conta2.Saldo);

            //Depositar 100 para cada conta
            conta1.Depositar(100);
            Console.WriteLine("O Saldo do titular " + conta1.Titular.Nome + " é de " + conta1.Saldo);

            conta2.Depositar(100);
            Console.WriteLine("O Saldo do titular " + conta2.Titular.Nome + " é de " + conta2.Saldo);

            //Transferir 
            conta1.Transferir(50, conta2);

            Console.WriteLine("O Saldo do titular " + conta1.Titular.Nome + " é de " + conta1.Saldo);
            Console.WriteLine("O Saldo do titular " + conta2.Titular.Nome + " é de " + conta2.Saldo);

            //Saber quantas contas foram criadas
            Console.WriteLine("A quantidade de contas criadas " + ContaCorrente.QtdContaCorrente);

            Console.ReadLine();
        } 
    }
}