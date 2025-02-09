namespace DvpPruebaTecnica.Application.DTOs;

public class PersonDto
{
    public Guid Id { get; set; }
    public string FirstNames { get; set; }
    public string LastNames { get; set; }
    public string IdentificationNumber { get; set; }
    public string IdentificationType { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string IdentificationFull { get; set; }
}

public class CreatePersonDto
{
    public string FirstNames { get; set; }
    public string LastNames { get; set; }
    public string IdentificationNumber { get; set; }
    public string IdentificationType { get; set; }
    public string Email { get; set; }
}

public class UpdatePersonDto
{
    public string FirstNames { get; set; }
    public string LastNames { get; set; }
    public string IdentificationNumber { get; set; }
    public string IdentificationType { get; set; }
    public string Email { get; set; }
}

