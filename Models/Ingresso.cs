namespace _2TDSPG_Cinema.Models
{
    public class Ingresso
    {
        public Reserva Reserva { get; set; } // Um ingresso está associado a uma reserva
        public Sessao Sessao { get; set; }  // Um ingresso está associado a uma sessao

        public Ingresso(Reserva reserva, Sessao sessao)
        {
            Reserva = reserva;
            Sessao = sessao;
        }
    }
}
