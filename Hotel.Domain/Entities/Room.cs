

namespace Hotel.Domain.Entities
{
    public class Room :Entity
    {
        public string? RoomNumber { get; set; }
        public RoomType RoomType { get;set; }
        public decimal Price { get;set; }
        public bool Available {  get;set; } 
    }
}
