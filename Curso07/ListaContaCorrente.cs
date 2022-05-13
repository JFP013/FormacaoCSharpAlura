using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso07
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] contas;
        private int _posicao;

        public ListaContaCorrente()
        {
            contas = new ContaCorrente[5];
            _posicao = 0;
        }

        public void AdcionarConta(ContaCorrente conta)
        {
            if(_posicao >= contas.Length)
            {
                int quantidadeNecessaria = contas.Length * 2;

                AumentarPosicaoArray(quantidadeNecessaria);
            }

            contas[_posicao] = conta;
            Console.WriteLine($"Criada a posição {_posicao}");
            _posicao++;
        }

        private void AumentarPosicaoArray(int quantidadeNecessaria)
        {
            ContaCorrente[] novoArray = new ContaCorrente[quantidadeNecessaria];

            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine("oi");
                novoArray[i] = contas[i];
            }

            contas = novoArray;
        }
    }
}
