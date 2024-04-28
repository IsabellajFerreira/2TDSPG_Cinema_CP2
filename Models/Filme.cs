using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2TDSPG_Cinema.Models
{
    [Table("2TDSPG_Tb_Filmes")]
    public class Filme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A descricao do filme é obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O diretor do filme é obrigatório.")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "A duração do filme deve ser um valor positivo.")]
        public int Duracao { get; set; }
        public List<Sessao> Sessoes { get; set; } // Um filme pode estar em varias sessões

        public Filme() { }

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
