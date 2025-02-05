using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Persistance
{
    public class HotelContext(DbContextOptions<HotelContext> options) : DbContext(options)
    {
        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Room>()
                .Property(p => p.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Reservation>()
            .Property(p => p.Id)
            .HasDefaultValueSql("gen_random_uuid()");

            modelBuilder.Entity<Reservation>()
            .Property(p => p.Id)
            .HasDefaultValueSql("gen_random_uuid()");
        }
    }
}
