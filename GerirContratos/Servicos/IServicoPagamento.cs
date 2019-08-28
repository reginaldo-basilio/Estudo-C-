using System;
using System.Collections.Generic;
using System.Text;
using GerirContratos.Entidades;

namespace GerirContratos.Servicos
{
    interface IServicoPagamento
    {
        double TaxaPagamento(double valor);

        double CalculoJuros(double valor, int qtdMeses);
    }
}
