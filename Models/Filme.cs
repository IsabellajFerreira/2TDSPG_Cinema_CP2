namespace _2TDSPG_Cinema.Models
{
    public class Filme
    {

        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public int Duracao { get; set; }
        public List<Sessao> Sessoes { get; set; } // Um filme pode estar em varias sessões

        public Filme(string titulo, string diretor, int duracao)
        {
            Titulo = titulo;
            Diretor = diretor;
            Duracao = duracao;
            Sessoes = new List<Sessao>();
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Diretor: {Diretor}, Duração: {Duracao} minutos";
        }

}
}
