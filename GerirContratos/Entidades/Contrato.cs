using System;
using System.Collections.Generic;
using System.Text;

namespace GerirContratos.Entidades
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorContrato { get; set; }
        public List<Parcela> listaParcela { get; set; }

        public Contrato(int numeroContrato, DateTime dataContrato, double valorContrato)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            listaParcela = new List<Parcela>();
        }

        public void AddPagamento(Parcela parcela)
        {
            listaParcela.Add(parcela);
        }

    }
}
