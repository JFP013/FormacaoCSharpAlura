using Curso03.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso03
{
    public class GerenciadorDeBonficacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return TotalBonificacao;
        }
    }
}