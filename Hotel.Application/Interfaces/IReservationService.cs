
using Hotel.Application.DTOs;

namespace Hotel.Application.Interfaces
{
    public interface IReservationService
    {
        Task AddReservationAsync(ReservationDto reservationDto);
        Task <IEnumerable<ReservationDto>> AllReservations();
    }
}
