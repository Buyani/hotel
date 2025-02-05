using Hotel.Application.Interfaces;
using System.Runtime.CompilerServices;

namespace Hotel.Api.Endpoints
{
    public static class ReservationEndpoints
    {
public static void MapReservationEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/reservations", (IReservationService service) =>
            {
                var reservations = service.AllReservations();
                return Results.Ok(reservations);
            });
        }
    }
}
