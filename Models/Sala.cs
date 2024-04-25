﻿namespace _2TDSPG_Cinema.Models
{
    public class Sala
    {
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public List<Sessao> Sessoes { get; set; }

        public Sala(int numero, int capacidade)
        {
            Numero = numero;
            Capacidade = capacidade;
            Sessoes = new List<Sessao>(); 
        }
    }
}
