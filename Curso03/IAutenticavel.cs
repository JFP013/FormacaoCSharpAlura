using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso03
{
    public interface IAutenticavel
    {
        public bool Autenticar(string senha);
    }
}
