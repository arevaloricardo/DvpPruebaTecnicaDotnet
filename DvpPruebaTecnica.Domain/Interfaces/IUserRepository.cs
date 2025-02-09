using DvpPruebaTecnica.Domain.Entities;

namespace DvpPruebaTecnica.Domain.Interfaces;

public interface IUserRepository
{
    Task<User> GetById(Guid id);
    Task<IEnumerable<User>> GetAll(int page, int size);
    Task<int> GetTotalCount();
    Task Add(User user);
    Task Update(User user);
    Task Delete(User user);
    Task<IEnumerable<User>> Autocomplete(string search);
    Task<User> GetByUsername(string user);
}