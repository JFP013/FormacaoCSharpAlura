using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso08
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if(x == null || y == null)
            {
                throw new ArgumentNullException();
            }

            if (x.Agencia < y.Agencia)
                return -1;

            if (x.Agencia == y.Agencia)
                return 0;

                return 1;
        }
    }
}
