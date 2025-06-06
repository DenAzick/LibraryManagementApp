﻿namespace LibraryManagementApp.Api.Models.Dto;

public class UserDto
{
   // public int Id { get; set; }
    public required string FName { get; set; }
    public required string LName { get; set; }
    // public string Username { get; set; } = string.Empty;
    //public required string PasswordHash { get; set; }
    public string BookTitle { get; set; }
    public string UserFullName { get; set; }

    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Passport { get; set; }
    public string? Email { get; set; }

    public ERole Role { get; set; } = ERole.Client;

}
