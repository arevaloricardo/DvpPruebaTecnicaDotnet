namespace DvpPruebaTecnica.Domain.Entities;

public class Person: AuditableEntity
{
    public string firstNames { get; set; }
    public string lastNames { get; set; }
    public string identificationNumber { get; set; }
    public string identificationType { get; set; }
    public string email { get; set; }
}