using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso08
{
    public static class ListExtensao
    {
        public static void AdcionarVarios(this List<int> listaInteiros, params int[] inteiros)
        {
            foreach (int item in inteiros)
            {
                listaInteiros.Add(item);
            }
        }
    }
}
