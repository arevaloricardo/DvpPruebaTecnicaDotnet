using DvpPruebaTecnica.Application.DTOs;

namespace DvpPruebaTecnica.Application.Interfaces;

public interface IAuthService
{
    Task<LoginResponseDto<UserDto>> LoginAsync(LoginRequestDto request);
}