

namespace Hotel.Domain.Entities
{
    public  class Reservation : Entity 
    {
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Guid RoomId { get; set; }
        public Guid UserId { get; set; }    
        public ReservationStatus Status { get; set; }   
        public Reservation() { }
    }
}
