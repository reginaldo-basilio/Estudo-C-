using System;
using System.Globalization;
using GerirContratos.Entidades;
using GerirContratos.Servicos;
using System.Collections.Generic;

namespace GerirContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do Contrato");
            Console.Write("Numero do Contrato: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data do Contrato: ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade de parcelas: ");
            int qtdParcela = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, dataContrato, valorContrato);

            ServicoContrato servicoContrato = new ServicoContrato(new ServicoPaypal());

            servicoContrato.ProcessaContrato(contrato, qtdParcela);

            Console.WriteLine("Listagem do parcelamento");
            foreach(Parcela parcela in contrato.listaParcela)
            {
                Console.WriteLine(parcela);
            }
            
        }
    }
}
