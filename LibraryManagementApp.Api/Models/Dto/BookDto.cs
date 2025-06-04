namespace LibraryManagementApp.Api.Models.Dto;

public class BookDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Author { get; set; }
    public DateTime Year { get; set; }
    public EGenre Genre { get; set; }
    public string ISBN { get; set; } = string.Empty;

    public int Quantity { get; set; }
}
