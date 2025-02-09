using DvpPruebaTecnica.Domain.Entities;

namespace DvpPruebaTecnica.Domain.Interfaces;

public interface IPersonRepository
{
    Task<Person> GetById(Guid id);
    Task<IEnumerable<Person>> GetAll(int page, int size);
    Task<int> GetTotalCount();
    Task Add(Person person);
    Task Update(Person person);
    Task Delete(Person person);
    Task<IEnumerable<Person>> Autocomplete(string search);
    Task<IEnumerable<Person>> GetPersonsFromStoredProcedure();
    
}