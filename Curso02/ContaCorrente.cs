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
        }

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
    }
}
