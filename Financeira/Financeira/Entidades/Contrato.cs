using System;
using System.Globalization;

namespace Financeira.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int prazoEmMeses { get; set; }

        public Contrato()
        {
        }
        public Contrato(int numero, string contratante, double valor, int prazoemmeses)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            prazoEmMeses = prazoemmeses;
        }
        public virtual double calcularPrestacao()
        {
            return Valor / prazoEmMeses;
        }

    }
}

