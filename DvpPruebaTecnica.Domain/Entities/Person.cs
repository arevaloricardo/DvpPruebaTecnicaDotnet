using DvpPruebaTecnica.Domain.Enums;

namespace DvpPruebaTecnica.Domain.Entities;

public class Person: AuditableEntity
{
    public string FirstNames { get; set; }
    public string LastNames { get; set; }
    public string IdentificationNumber { get; set; }
    public IdentificationType IdentificationType { get; set; }
    public string Email { get; set; }
}