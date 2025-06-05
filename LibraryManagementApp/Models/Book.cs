using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApp.Models;

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
}

public enum EGenre
{
    [Display(Name = "Romance")]
    Romance,
    [Display(Name = "Detective")]
    Detective,
    [Display(Name = "ScienceFiction")]
    ScienceFiction,
    [Display(Name = "Fantasy")]
    Fantasy,
    [Display(Name = "Thriller")]
    Thriller,
    [Display(Name = "Horror")]
    Horror,
    [Display(Name = "HistoricalFiction")]
    HistoricalFiction,
    [Display(Name = "Biography")]
    Biography,
    [Display(Name = "SelfHelp")]
    SelfHelp,
    [Display(Name = "History")]
    History,
    [Display(Name = "ScienceTechnology")]
    ScienceTechnology,
    [Display(Name = "Classics")]
    Classics,
    [Display(Name = "Poetry")]
    Poetry


}