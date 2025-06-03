namespace LibraryManagementApp.Api.Models;

public class Book
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? Author { get; set; }
    public DateTime Year { get; set; }
    public EGenre Genre { get; set; }
    public string ISBN { get; set; } = string.Empty;

    public int Quantity { get; set; }
    public List<int> BookLoanId { get; set; } = new();
}


public enum EGenre
{
    Romance,
    Detective,
    ScienceFiction,
    Fantasy,
    Thriller,
    Horror,
    HistoricalFiction,
    Biography,
    SelfHelp,
    History,
    ScienceTechnology,
    Classics,
    Poetry


}