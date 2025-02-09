using AutoMapper;
using DvpPruebaTecnica.Application.DTOs;
using DvpPruebaTecnica.Application.Interfaces;
using DvpPruebaTecnica.Application.Helpers;
using DvpPruebaTecnica.Domain.Entities;
using DvpPruebaTecnica.Domain.Interfaces;

namespace DvpPruebaTecnica.Application.Services;

public class PersonService(IPersonRepository personRepository, IMapper mapper) : IPersonService
{
    
    public async Task<PersonDto> GetById(Guid id)
    {
        var person = await personRepository.GetById(id);
        return mapper.Map<PersonDto>(person);
    }

    public async Task<PaginatedResponse<PersonDto>> GetAll(int page, int size)
    {
        var persons = await personRepository.GetAll(page, size);
        var total = await personRepository.GetTotalCount();
        
        var dtoList = mapper.Map<IEnumerable<PersonDto>>(persons);
        
        var totalPages = PaginationHelper.CountTotalPages(total, size);
        
        return new PaginatedResponse<PersonDto>
        {
            Items = dtoList,
            Total = total,
            TotalPages = totalPages,
            ActualPage = page
        };
    }

    public async Task<PersonDto> Create(CreatePersonDto dto, string currentUser)
    {
        var person = mapper.Map<Person>(dto);
        
        person.CreatedAt = DateTime.UtcNow;
        person.CreatedBy = currentUser;
        
        await personRepository.Add(person);
        
        return mapper.Map<PersonDto>(person);
    }

    public Task Update(Guid id, UpdatePersonDto dto, string currentUser)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id, string currentUser)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PersonDto>> Autocomplete(string term)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PersonDto>> GetPersonsFromStoredProcedure()
    {
        throw new NotImplementedException();
    }
}