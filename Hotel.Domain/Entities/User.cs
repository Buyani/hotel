

namespace Hotel.Domain.Entities
{
    public  class User :Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }   
        public List<Reservation>? Bookings { get; set; }
    }
}
