using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2TDSPG_Cinema.Models
{
    [Table("2TDSPG_Tb_Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A idade do cliente é obrigatória.")]
        [Range(1, 150, ErrorMessage = "A idade do cliente deve estar entre 1 e 150 anos.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O número do cliente é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O número do cliente deve ser um valor positivo.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "O número do cliente deve conter apenas números.")]
        public int NumeroCliente { get; set; }

        internal Reserva Reserva { get; set; } // Cliente pode ter no máximo uma reserva

        public Cliente() { }

        public Cliente(string nome, int idade, string endereco, int numeroCliente)
        {
            Nome = nome;
            Idade = idade;
            //Endereco = endereco;
            NumeroCliente = numeroCliente;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Número do Cliente: {NumeroCliente}";
        }
    }
}
