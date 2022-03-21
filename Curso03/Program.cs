using Curso03.Funcionarios;
using System;

namespace Curso03
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonficacao gerenciadorDeBonificacao = new GerenciadorDeBonficacao();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Jefferson";
            funcionario.Salario = 2000;

            gerenciadorDeBonificacao.Registrar(funcionario);

            Diretor diretor = new Diretor();
            diretor.Nome = "Camila";
            diretor.Salario = 5000;

            gerenciadorDeBonificacao.Registrar(diretor);

            Console.WriteLine("O salario do " + funcionario.Nome + " é: " + funcionario.Salario);
            Console.WriteLine("A bonificação do " + funcionario.Nome + " é de: " + funcionario.GetBonificacao());

            Console.WriteLine("O salario do " + diretor.Nome + " é: " + diretor.Salario);
            Console.WriteLine("A bonificação do " + diretor.Nome + " é de: " + diretor.GetBonificacao());

            Console.WriteLine("O total de bonificação é de: " + gerenciadorDeBonificacao.GetTotalBonificacao());

            Console.ReadLine();


        }
    }
}
