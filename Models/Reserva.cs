using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2TDSPG_Cinema.Models
{
    [Table("2TDSPG_Tb_Reservas")]
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Cliente Cliente { get; set; } // Uma reserva pertence a um cliente

        public List<Ingresso> Ingressos { get; set; }  // uma reserva pode ter varios ingressosx

        public Reserva() { }
        public Reserva(Cliente cliente)
        {
            Cliente = cliente;
            Ingressos = new List<Ingresso>();

        }

    }
}

    

