namespace DvpPruebaTecnica.Domain.Entities;

public class User: AuditableEntity
{
    public string username { get; set; }
    public string password { get; set; }
}