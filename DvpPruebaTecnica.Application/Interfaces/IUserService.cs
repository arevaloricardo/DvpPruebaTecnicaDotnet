using DvpPruebaTecnica.Application.DTOs;

namespace DvpPruebaTecnica.Application.Interfaces;

public interface IUserService
{
    Task<UserDto> GetByIdAsync(Guid id);
    Task<PaginatedResponse<UserDto>> GetAllAsync(int page, int size);
    Task<UserDto> CreateAsync(CreateUserDto dto, string currentUser);
    Task UpdateAsync(Guid id, UpdateUserDto dto, string currentUser);
    Task DeleteAsync(Guid id, string currentUser);
    Task<IEnumerable<UserDto>> AutocompleteAsync(string term);
    Task<UserDto> GetByUsernameAsync(string username);
}