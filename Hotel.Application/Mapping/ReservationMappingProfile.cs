using AutoMapper;
using Hotel.Application.DTOs;
using Hotel.Domain.Entities;

namespace Hotel.Application.Mapping
{
    public class ReservationMappingProfile :Profile
    {
        public ReservationMappingProfile()
        {
            CreateMap<Reservation, ReservationDto>();
            CreateMap<ReservationDto, Reservation>();
        }
    }
}
