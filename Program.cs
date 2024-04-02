
using ProjetoHospedagem.Models;
using ProjetoHospedagem.ValueObjects;


Suite suiteComum = new Suite(TipoSuite.Comun);
Suite suiteFamilia = new Suite(TipoSuite.Familia);
Suite suiteMaster = new Suite(TipoSuite.Master);
Suite suitePremium = new Suite(TipoSuite.Premium);
Suite suitePresidencial = new Suite(TipoSuite.Presidencial);

Hospedes hospedes = new Hospedes();
hospedes.CadastrarHospedes("Marcelo", "Morais");
hospedes.CadastrarHospedes("Elidiane", "Ferreira");
hospedes.CadastrarHospedes("Esther", "Morais");
hospedes.CadastrarHospedes("Elisa", "Morais");


Reserva reserva = new Reserva();
reserva.Reservar(hospedes, suiteComum, 15);




