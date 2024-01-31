// See https://aka.ms/new-console-template for more information
using Hospedagem.Models;



List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");
//Pessoa p3 = new Pessoa(nome: "Hospede 3");


hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);


Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");