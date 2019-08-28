using System;
using System.Collections.Generic;
using GerirContratos.Entidades;

namespace GerirContratos.Servicos
{
    class ServicoContrato
    {
        private IServicoPagamento _servicoPagamento;

        public ServicoContrato(IServicoPagamento servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }

        public void ProcessaContrato(Contrato contrato, int qtdMes)
        {
            double ParcelaBasica = contrato.ValorContrato / qtdMes;
            for (int i = 1; i <= qtdMes; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);
                double AtualzaParcela = ParcelaBasica + _servicoPagamento.CalculoJuros(ParcelaBasica, i);
                double ParcelaTotal = AtualzaParcela + _servicoPagamento.TaxaPagamento(AtualzaParcela);
                contrato.AddPagamento(new Parcela(data, ParcelaTotal));
            }
        }
    }
}
