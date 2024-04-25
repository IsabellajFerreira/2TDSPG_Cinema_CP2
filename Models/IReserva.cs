namespace _2TDSPG_Cinema.Models
{
    public interface IReserva
    {
        void Reservar(Ingresso ingresso);
        void CancelarReserva(Ingresso ingresso);
    }
}
