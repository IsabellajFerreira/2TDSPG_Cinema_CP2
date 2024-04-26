using System.ComponentModel.DataAnnotations;

namespace _2TDSPG_Cinema.Models
{
    public class Sala
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O número da sala é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O número da sala deve ser um valor positivo.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "A capacidade da sala é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A capacidade da sala deve ser um valor positivo.")]
        public int Capacidade { get; set; }
        public List<Sessao> Sessoes { get; set; } // Uma sala pode ter várias sessões

        public Sala(int numero, int capacidade)
        {
            Numero = numero;
            Capacidade = capacidade;
            Sessoes = new List<Sessao>(); 
        }
    }
}
