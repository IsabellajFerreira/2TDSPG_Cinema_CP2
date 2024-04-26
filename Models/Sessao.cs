using System.ComponentModel.DataAnnotations;

namespace _2TDSPG_Cinema.Models
{
    public class Sessao
    {
        public List<Filme> Filmes { get; set; } // uma sessao pode ter varios filmes

        [Required(ErrorMessage = "O horário da sessão é obrigatório.")]
        [DataType(DataType.DateTime, ErrorMessage = "Formato de horário inválido.")]
        public DateTime Horario { get; set; }

        [Required(ErrorMessage = "A capacidade da sessão é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A capacidade da sessão deve ser um valor positivo.")]
        internal int Capacidade { get; set; }

        [Required(ErrorMessage = "O número de ingressos disponíveis é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O número de ingressos disponíveis deve ser um valor positivo ou zero.")]
        public int IngressosDisponiveis { get; set; }

        [Required(ErrorMessage = "O número da sala é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O número da sala deve ser um valor positivo.")]
        protected int NumeroDaSala { get; set; }

        [Required(ErrorMessage = "A sala é obrigatória.")]
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
