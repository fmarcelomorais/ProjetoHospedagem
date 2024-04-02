using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoHospedagem.ValueObjects;

namespace ProjetoHospedagem.Models
{
    public class Suite
    {
        public TipoSuite TipoSuite {get; set;}
        public int Capacidade {get; set;} 
        public double ValorDiaria {get; set;}   
        
        public Suite(TipoSuite tipo)
        {
            switch(tipo)
            {
                case TipoSuite.Comun:
                    TipoSuite = TipoSuite.Comun;
                    Capacidade = 5;
                    ValorDiaria = 200;
                    break;
                case TipoSuite.Familia:
                    TipoSuite = TipoSuite.Familia;
                    Capacidade = 10;
                    ValorDiaria = 300;
                    break;
                case TipoSuite.Master:
                    TipoSuite = TipoSuite.Master;
                    Capacidade = 15;
                    ValorDiaria = 400;
                    break;
                case TipoSuite.Premium:
                    TipoSuite = TipoSuite.Premium;
                    Capacidade = 20;
                    ValorDiaria = 500;
                    break;
                case TipoSuite.Presidencial:
                    TipoSuite = TipoSuite = TipoSuite.Presidencial;
                    Capacidade = 25;
                    ValorDiaria = 1000;
                    break;
            }
        }
    }
}