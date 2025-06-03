namespace LibraryManagementApp.Api.Models;

public class User
{
    public int Id { get; set; }
    public required string FName { get; set; }
    public required string LName { get; set; }
    public string Username { get; set; } = string.Empty;
    public required string PasswordHash { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Passport { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow.AddHours(5);


    public ERole Role { get; set; } = ERole.Client;

    public List<int> BookLoanId { get; set; } = new();
}

public enum ERole
{
    Admin,
    Librarian,
    Client
}