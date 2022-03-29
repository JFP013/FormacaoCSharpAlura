using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso02
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int numeroConta)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;

            QtdContaCorrente++;
        }

        public static int QtdContaCorrente { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
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