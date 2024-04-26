namespace _2TDSPG_Cinema.Models
{
    public class Sessao
    {
        public List<Filme> Filmes { get; set; } // uma sessao pode ter varios filmes
        public DateTime Horario { get; set; }
        internal int Capacidade { get; set; }
        public int IngressosDisponiveis { get; set; }
        protected int NumeroDaSala { get; set; }

        public Sala Sala { get; set; } // Uma sessão ocorre em apenas uma sala

        public Sessao(DateTime horario, int capacidade, int ingressosDisponiveis, Sala sala)  
        {
            Filmes = new List<Filme>();
            Horario = horario;
            Capacidade = capacidade;
            IngressosDisponiveis = ingressosDisponiveis;
            Sala = sala;
        }
        }
}
