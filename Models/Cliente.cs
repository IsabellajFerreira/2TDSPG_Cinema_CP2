namespace _2TDSPG_Cinema.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public int NumeroCliente { get; set; }
        internal Reserva Reserva { get; set; } // Cliente pode ter no máximo uma reserva

        public Cliente(string nome, int idade, string endereco, int numeroCliente)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            NumeroCliente = numeroCliente;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Endereço: {Endereco}, Número do Cliente: {NumeroCliente}";
        }
    }
}
