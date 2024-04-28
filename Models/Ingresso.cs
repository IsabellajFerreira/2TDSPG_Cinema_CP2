using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2TDSPG_Cinema.Models
{
    [Table("2TDSPG_Tb_Ingressos")]
    public class Ingresso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Valor { get; set; }
        public Reserva Reserva { get; set; } // Um ingresso está associado a uma reserva
        public Sessao Sessao { get; set; }  // Um ingresso está associado a uma sessao

        public Ingresso() { }
        public Ingresso(Reserva reserva, Sessao sessao, string valor)
        {
            Valor = valor;
            Reserva = reserva;
            Sessao = sessao;
        }
    }
}
