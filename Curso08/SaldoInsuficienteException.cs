using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso08
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this("Não foi possível sacar R$" + valorSaque + ", seu saldo é de R$" + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }

        public double Saldo { get; }
        public double ValorSaque { get; }
    }
}
