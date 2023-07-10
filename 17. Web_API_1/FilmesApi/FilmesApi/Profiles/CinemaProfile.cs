using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            // eu estou dizendo: para meu mebro ReadCinemaDto, eu vou acessar meu cinemaDto, e acessar o meu ReadEnderecoDto, de forma que eu consigar fazer o map do endereco do cinema para o meu ReadCinemaDto
            CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco)).ForMember(cinemaDto => cinemaDto.Sessoes, opt => opt.MapFrom(cinema => cinema.Sessoes));
            CreateMap<UpdateCinemaDto, Cinema>();
            //CreateMap<Cinema, UpdateCinemaDto>();
            
        }
    }
}
