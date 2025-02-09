// MappingProfile.Usuario.cs
using AutoMapper;
using DvpPruebaTecnica.Application.DTOs;
using DvpPruebaTecnica.Domain.Entities;

public class UsuarioMappingProfile : Profile
{
    public UsuarioMappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();
    }
}