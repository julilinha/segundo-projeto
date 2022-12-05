using System;
using System.Globalization;

namespace Financeira.Entidades
{
    class ContratoPessoaFisica : Contrato
    {
        public int Cpf { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
      
        public ContratoPessoaFisica()
        {
        }
        public ContratoPessoaFisica(int numero, string contratante, double valor, int prazoemmeses, int cpf, int idade, string nome) : base(numero, contratante, valor, prazoemmeses)
        {
            Cpf = cpf;
            Idade = idade;
            Nome = nome;
            
        }

        public override double calcularPrestacao()
        {
            return base.calcularPrestacao();
        }

    }
}