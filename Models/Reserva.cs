using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHospedagem.ValueObjects;

namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public Suite? Suite {get; set;}
        public int DiasReservados {get; set;}
        public int Numero {get; set;}
        public double ValorReserva {get; set;}
        public double Desconto { get; set; }
        
        

        public void Reservar(Hospedes hospedes, Suite suite, int dias)
        {

            //Suite = suite;
            DiasReservados = dias;
            var capacidadeOk = VerificaCapacidadeHospedeSuite(hospedes, suite);
            if(capacidadeOk)
            {
                var rdn = new Random();
                Numero = rdn.Next(0,5000);
                CalcularValorDaHospedagem(suite);
                System.Console.WriteLine($"---------[ RESERVA Nº {Numero} ]---------------");
                System.Console.WriteLine("--------- HOSPEDES ----------------");
                foreach(var h in hospedes.ListaDePessoas)
                {
                    System.Console.WriteLine($"NOME COMPLETO: {h.Nome} {h.Sobrenome}");
                }
                System.Console.WriteLine("---------------------------------------------------");
                System.Console.WriteLine("--------- SUITE -----------------------------------");
                System.Console.WriteLine($"Tipo de Suite:-------------------{suite.TipoSuite}");
                System.Console.WriteLine($"Capacidade ate:------- {suite.Capacidade} pessoas.");
                System.Console.WriteLine($"Valor da Diaria: {suite.ValorDiaria.ToString("C")}");
                System.Console.WriteLine("---------------------------------------------------");
                System.Console.WriteLine($"Quantidade de dias:-------------- {DiasReservados}");

                System.Console.WriteLine($"TOTAL:--------------- {ValorReserva.ToString("C")}");
                if(Desconto > 0)
                    System.Console.WriteLine($"Desconto de {Desconto.ToString("C")} para hospedagem a partir de 10 dias.");
            }
            else
            {
                System.Console.WriteLine("Não e possivel reservar Suite com numero de hospedes menor que a capacidade da suite.");
                System.Console.WriteLine(IndicacaoSuite(hospedes, suite));
                //throw new Exception();
            }
        }

        private bool VerificaCapacidadeHospedeSuite(Hospedes hospedes, Suite suite)
        {
            bool ok = false;

            if(hospedes.ListaDePessoas.Count <= suite.Capacidade) 
            {
                ok = true;
            }
            return ok;
        }

        private void CalcularValorDaHospedagem(Suite suite)
        {            
            if(DiasReservados >= 10)
            {
                Desconto = suite.ValorDiaria * DiasReservados * 0.1;
                ValorReserva = suite.ValorDiaria * DiasReservados - Desconto;
            }
            else
            {
                ValorReserva = suite.ValorDiaria * DiasReservados;
            }
        }
        private string IndicacaoSuite(Hospedes hospede, Suite suite)
        {
            string indicacao = "";
            int qtd = hospede.ListaDePessoas.Count;
            switch(qtd)
            {
                case <= 5:
                    indicacao = $"{TipoSuite.Comun}";
                    break;
                case <= 10:
                    indicacao = $"{TipoSuite.Familia}";
                    break;
                case <= 15:
                    indicacao = $"{TipoSuite.Master}";
                    break;
                case <= 20:
                    indicacao = $"{TipoSuite.Premium}";
                    break;
                case >= 25:
                    indicacao = $"{TipoSuite.Presidencial}";
                    break;
                default:
                    break;
            }
            return $"Indicamos para o seu caso a Suite {indicacao}";
        }
    }
}