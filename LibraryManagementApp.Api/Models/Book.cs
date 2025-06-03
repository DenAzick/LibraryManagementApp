namespace LibraryManagementApp.Api.Models;

public class Book
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Author { get; set; }
    public int Quantity { get; set; }

    public List<BookLoan> BookLoans { get; set; } = new();
}
