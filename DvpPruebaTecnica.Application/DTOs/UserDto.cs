﻿namespace DvpPruebaTecnica.Application.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string Username { get; set; }
}

public class CreateUserDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class UpdateUserDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}