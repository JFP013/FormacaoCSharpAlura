using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso04
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int numeroConta)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("A agencia mão pode ser maior ou igual a 0", nameof(agencia));
            }
            if(numeroConta <= 0)
            {
                throw new ArgumentException("O numero da conta não pode ser menor ou igual a 0", nameof(numeroConta));
            }

            Agencia = agencia;
            NumeroConta = numeroConta;

            QtdContaCorrente++;
        }

        public static int QtdContaCorrente { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int NumeroConta { get; }
        public double Saldo { get;  private set; }

        public bool Sacar(double valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor para saque deve ser maior que 0");
                return false;
            }

            if(Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do deposito deve ser maior que 0");
                return;
            }

            Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaCorrente)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor da transferência deve ser maior que 0");
                return false;
            }

            if(Saldo < valor)
            {
                Console.WriteLine("Seu saldo é insuficiente para fazer a transferência");
                return false;
            }

            contaCorrente.Saldo += valor;
            Saldo -= valor;
            return true;

        }
    }
}