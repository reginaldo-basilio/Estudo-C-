using System;
using System.Collections.Generic;
using System.Text;
using GerirContratos.Entidades;

namespace GerirContratos.Servicos
{
    class ServicoPaypal : IServicoPagamento
    {
        private const double PercentualTaxa = 0.02;
        private const double JurosMes = 0.01;
        public double TaxaPagamento(double valor)
        {
            return valor * PercentualTaxa;
        }

        public double CalculoJuros(double valor, int qtdMeses)
        {
            return valor * JurosMes * qtdMeses;
        }       

        
    }
}
