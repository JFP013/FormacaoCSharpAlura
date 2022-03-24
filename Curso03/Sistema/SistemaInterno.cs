using Curso03.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso03.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autenticavel, string senha)
        {
            if (!autenticavel.Autenticar(senha))
            {
                Console.WriteLine("Sua senha está errada!");
                return false;
            }

            Console.WriteLine("Seja bem vindo!");
            return true;
        }        
    }
}