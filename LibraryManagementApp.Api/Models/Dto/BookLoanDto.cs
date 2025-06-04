namespace LibraryManagementApp.Api.Models.Dto;

public class BookLoanDto
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public DateTime BorrowedAt { get; set; }
    public DateTime DueDate { get; set; }
    public bool Returned { get; set; }
    //public DateTime? ReturnedAt { get; set; }
    public decimal FineAmount { get; set; }
}
