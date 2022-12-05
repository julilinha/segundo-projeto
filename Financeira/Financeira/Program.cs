using System;
using System.Globalization;
using System.Collections.Generic;

namespace Financeira.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> list = new List<Contrato>();
            Console.Write("Contrato de pessoa física ou juridica (f/j): ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Insira o número do contrato: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Insira o nome da contratante: ");
            string Contratante = Console.ReadLine();
            Console.Write("Insira o valor do contrato: ");
            double Valor = double.Parse(Console.ReadLine());
            Console.Write("Insira o prazo do contrato (em meses): ");
            int prazoEmMeses = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (ch == 'f')
            {
                Console.Write("Entre com o CPF da pessoa: ");
                int Cpf = int.Parse(Console.ReadLine());
                Console.Write("Entre com a idade da pessoa: ");
                int Idade = int.Parse(Console.ReadLine());
                Console.Write("Entre com o nome da pessoa: ");
                string Nome = Console.ReadLine();
                list.Add(new ContratoPessoaFisica(Numero, Contratante, Valor, prazoEmMeses, Cpf, Idade, Nome));

            }
            if (ch == 'j')
            {
                Console.Write("Entre com o CNPJ da pessoa: ");
                int Cnpj = int.Parse(Console.ReadLine());
                Console.Write("Entre com a inscrição estadual da empresa contratante: ");
                int Ieec = int.Parse(Console.ReadLine());
                list.Add(new ContratoPessoaJuridica(Numero, Contratante, Valor, prazoEmMeses, Cnpj, Ieec));

            }
            foreach (ContratoPessoaFisica emp in list)
            {
                Console.WriteLine(emp.calcularPrestacao());
            }
            foreach (ContratoPessoaJuridica emp in list)
            {
                Console.WriteLine(emp.calcularPrestacao());
            }


        }
    }
}
