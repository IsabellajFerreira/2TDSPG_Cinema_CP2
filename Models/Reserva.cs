using System.Collections.Generic;

namespace _2TDSPG_Cinema.Models
{
    public class Reserva
    {

        public Cliente Cliente { get; set; } // Uma reserva pertence a um cliente

        public List<Ingresso> Ingressos { get; set; }  // uma reserva pode ter varios ingressosx
        public Reserva(Cliente cliente)
        {
            Cliente = cliente;
            Ingressos = new List<Ingresso>();

        }

    }
}

    

