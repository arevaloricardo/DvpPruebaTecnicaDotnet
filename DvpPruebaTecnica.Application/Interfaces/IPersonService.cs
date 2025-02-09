using DvpPruebaTecnica.Application.DTOs;

namespace DvpPruebaTecnica.Application.Interfaces;

public interface IPersonService
{
    Task<PersonDto> GetById(Guid id);
    Task<PaginatedResponse<PersonDto>> GetAll(int page, int size);
    Task<PersonDto> Create(CreatePersonDto dto, string currentUser);
    Task Update(Guid id, UpdatePersonDto dto, string currentUser);
    Task Delete(Guid id, string currentUser);
    Task<IEnumerable<PersonDto>> Autocomplete(string term);
    Task<IEnumerable<PersonDto>> GetPersonsFromStoredProcedure();
}