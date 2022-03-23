using Curso03.Funcionarios;
using System;

namespace Curso03
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonficacao gerenciadorDeBonificacao = new GerenciadorDeBonficacao();

            //Criando os objetos que derivam de funcionário
            Desenvolvedor deselvolvedor = new Desenvolvedor("321654987-78");
            deselvolvedor.Nome = "Jefferson";

            gerenciadorDeBonificacao.Registrar(deselvolvedor);

            Diretor diretor = new Diretor("321456789-98");
            diretor.Nome = "Camila";

            gerenciadorDeBonificacao.Registrar(diretor);

            Designer designer = new Designer("369852114-52");
            designer.Nome = "Thiago";

            gerenciadorDeBonificacao.Registrar(designer);

            GerenteDeConta gerenteDeConta = new GerenteDeConta("321478521-65");
            gerenteDeConta.Nome = "Melissa";

            gerenciadorDeBonificacao.Registrar(gerenteDeConta);

            Auxiliar auxiliar = new Auxiliar("357412359-12");
            auxiliar.Nome = "Renato";

            gerenciadorDeBonificacao.Registrar(auxiliar);

            //Exibindo todos resultados
            Console.WriteLine("O salario do " + deselvolvedor.Nome + " é: " + deselvolvedor.Salario);
            Console.WriteLine("A bonificação do " + deselvolvedor.Nome + " é de: " + deselvolvedor.GetBonificacao());
            deselvolvedor.AumentarSalario();
            Console.WriteLine("Com o aumento, o novo salário do " + deselvolvedor.Nome + " é de: " + deselvolvedor.Salario);

            Console.WriteLine("");

            Console.WriteLine("O salario do " + diretor.Nome + " é: " + diretor.Salario);
            Console.WriteLine("A bonificação do " + diretor.Nome + " é de: " + diretor.GetBonificacao());
            diretor.AumentarSalario();
            Console.WriteLine("Com o aumento, o novo salário do " + diretor.Nome + " é de: " + diretor.Salario);

            Console.WriteLine("");

            Console.WriteLine("O salario do " + designer.Nome + " é: " + designer.Salario);
            Console.WriteLine("A bonificação do " + designer.Nome + " é de: " + designer.GetBonificacao());
            designer.AumentarSalario();
            Console.WriteLine("Com o aumento, o novo salário do " + designer.Nome + " é de: " + designer.Salario);

            Console.WriteLine("");

            Console.WriteLine("O salario do " + gerenteDeConta.Nome + " é: " + gerenteDeConta.Salario);
            Console.WriteLine("A bonificação do " + gerenteDeConta.Nome + " é de: " + gerenteDeConta.GetBonificacao());
            gerenteDeConta.AumentarSalario();
            Console.WriteLine("Com o aumento, o novo salário do " + gerenteDeConta.Nome + " é de: " + gerenteDeConta.Salario);

            Console.WriteLine("");

            Console.WriteLine("O salario do " + auxiliar.Nome + " é: " + auxiliar.Salario);
            Console.WriteLine("A bonificação do " + auxiliar.Nome + " é de: " + auxiliar.GetBonificacao());
            auxiliar.AumentarSalario();
            Console.WriteLine("Com o aumento, o novo salário do " + auxiliar.Nome + " é de: " + auxiliar.Salario);

            Console.WriteLine("");

            Console.WriteLine("O total de bonificação é de: " + gerenciadorDeBonificacao.GetTotalBonificacao());

            Console.WriteLine("");

            Console.WriteLine("O total de Funcionários é de: " + Funcionario.QtdFuncionario);

            Console.ReadLine();
        }
    }
}