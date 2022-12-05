using System;
using System.Globalization;

namespace Financeira.Entidades
{
    class ContratoPessoaJuridica : Contrato
    {
        public int Cnpj { get; set; }
        public int Ieec { get; set; }

        public ContratoPessoaJuridica()
        {
        }
        public ContratoPessoaJuridica(int numero, string contratante, double valor, int prazoemmeses, int cnpj, int ieec) : base(numero, contratante, valor, prazoemmeses)
        {
            Cnpj = cnpj;
            Ieec = ieec;
        }
        public override double calcularPrestacao()
        {
            return base.calcularPrestacao() + (3 * prazoEmMeses);
        }

    }
}