namespace _2TDSPG_Cinema.Models
{
    public class Ingresso
    {
        public Sessao Sessao { get; set; }
        public Cliente Cliente { get; set; }

        public Ingresso(Sessao sessao, Cliente cliente)
        {
            Sessao = sessao;
            Cliente = cliente;
        }
    }
}
