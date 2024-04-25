namespace _2TDSPG_Cinema.Models
{
    public class Sessao
    {
        public Filme Filme { get; set; }
        public DateTime Horario { get; set; }
        internal int Capacidade { get; set; }
        public int IngressosDisponiveis { get; set; }
        protected int NumeroDaSala { get; set; }

        public Sessao(Filme filme, DateTime horario, int capacidade, int ingressosDisponiveis)  
        {
            Filme = filme;
            Horario = horario;
            Capacidade = capacidade;
            IngressosDisponiveis = ingressosDisponiveis;
        }
        }
}
