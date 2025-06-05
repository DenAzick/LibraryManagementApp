namespace LibraryManagementApp.Api.Models.Dto;

public class BookLoanDto
{
    public int Id { get; set; }

    public string BookTitle { get; set; } = string.Empty;
    public string UserFullName { get; set; } = string.Empty;

    public DateTime LoanDate { get; set; } 
    public DateTime DueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public bool Returned => ReturnDate.HasValue;

    public decimal FineAmount { get; set; }
}
