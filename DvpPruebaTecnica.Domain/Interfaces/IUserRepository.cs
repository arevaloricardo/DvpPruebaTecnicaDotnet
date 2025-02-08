using DvpPruebaTecnica.Domain.Entities;

namespace DvpPruebaTecnica.Domain.Interfaces;

public interface IUserRepository
{
    Task<User> GetByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllAsync(int page, int size);
    Task<int> GetTotalCountAsync();
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
    Task<IEnumerable<User>> AutocompleteAsync(string search);
    Task<User> GetByUsernameAsync(string user);
}