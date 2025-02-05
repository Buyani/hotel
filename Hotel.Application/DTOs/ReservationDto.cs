

namespace Hotel.Application.DTOs
{
    public  class ReservationDto
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Guid RoomId { get; set; }
        public Guid UserId { get; set; }
    }
}
