using AutoMapper;
using DvpPruebaTecnica.Application.DTOs;
using DvpPruebaTecnica.Domain.Entities;
using DvpPruebaTecnica.Domain.Enums;


namespace DvpPruebaTecnica.Application.Mapping;

public class PersonMappingProfile : Profile
{
    public PersonMappingProfile()
    {
        CreateMap<Person, PersonDto>()
            .ForMember(dest => dest.IdentificationType, opt => opt.MapFrom(src => src.IdentificationType.ToString()))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstNames + " " + src.LastNames))
            .ForMember(dest => dest.IdentificationFull, opt => opt.MapFrom(src => src.IdentificationNumber + src.IdentificationType.ToString()));
        CreateMap<CreatePersonDto, Person>()
            .ForMember(dest => dest.IdentificationType, opt => opt.MapFrom(src => Enum.Parse<IdentificationType>(src.IdentificationType)));
        CreateMap<UpdatePersonDto, Person>()
            .ForMember(dest => dest.IdentificationType, opt => opt.MapFrom(src => Enum.Parse<IdentificationType>(src.IdentificationType)));
    }
}