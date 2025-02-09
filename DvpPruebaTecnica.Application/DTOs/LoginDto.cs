namespace DvpPruebaTecnica.Application.DTOs;

public class LoginRequestDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class LoginResponseDto<T>
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
    public T User { get; set; }
}