﻿using System.Text;
using Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa(nome: "Hóspede 1");
Pessoa pessoa2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);

Reserva reserva = new Reserva(diasReservados: 7);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");