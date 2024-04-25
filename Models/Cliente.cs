namespace _2TDSPG_Cinema.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public int NumeroCliente { get; set; }
        internal List<Reserva> Reservas { get; set; }

        public Cliente(string nome, int idade, string endereco, int numeroCliente)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            NumeroCliente = numeroCliente;
            Reservas = new List<Reserva>();
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Endereço: {Endereco}, Número do Cliente: {NumeroCliente}";
        }
    }
}
