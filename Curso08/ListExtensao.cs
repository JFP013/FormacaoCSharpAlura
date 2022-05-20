using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso08
{
    public static class ListExtensao
    {
        public static void AdcionarVarios<T>(this List<T> listaInteiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaInteiros.Add(item);
            }
        }
    }
}
