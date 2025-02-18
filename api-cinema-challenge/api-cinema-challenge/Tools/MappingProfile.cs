﻿using api_cinema_challenge.DTOs;
using api_cinema_challenge.DTOs.NestedDTOs;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<Movie, MovieDTO>();
            CreateMap<Screening, ScreeningDTO>();
            CreateMap<Ticket, TicketDTO>();
            CreateMap<Screening, NestedScreeningDTO>();
            CreateMap<Ticket, NestedTicketDTO>();
            CreateMap<Ticket, MinimalTicketDTO>();
        }
    }
}
