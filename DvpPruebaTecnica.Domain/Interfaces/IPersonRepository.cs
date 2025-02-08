using DvpPruebaTecnica.Domain.Entities;

namespace DvpPruebaTecnica.Domain.Interfaces;

public interface IPersonRepository
{
    Task<Person> GetByIdAsync(Guid id);
    Task<IEnumerable<Person>> GetAllAsync(int page, int size);
    Task<int> GetTotalCountAsync();
    Task AddAsync(Person person);
    Task UpdateAsync(Person person);
    Task DeleteAsync(Person person);
    Task<IEnumerable<Person>> AutocompleteAsync(string search);
    Task<IEnumerable<Person>> GetPersonsFromStoredProcedureAsync();
    
}