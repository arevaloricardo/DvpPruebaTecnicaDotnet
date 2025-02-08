namespace DvpPruebaTecnica.Domain.Entities;

public class User: AuditableEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
}