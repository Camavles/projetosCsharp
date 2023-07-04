using AutoMapper;
using FilmesApi.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        // fazendo o mapper;
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();


    }
}
