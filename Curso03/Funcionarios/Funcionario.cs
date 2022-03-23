using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso03.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;

            QtdFuncionario++;
        }

        public static int QtdFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}