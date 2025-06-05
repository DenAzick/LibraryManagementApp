namespace LibraryManagementApp.Api.Models;

public class BookLoan
{
    public BookLoan()
    {
        BorrowedAt = DateTime.UtcNow.AddHours(5);
        DueDate = BorrowedAt.AddDays(3);
    }


    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public DateTime BorrowedAt { get; set; }
    public DateTime DueDate { get; set;} 

    public bool Returned {
        get => ReturnedAt.HasValue;
        set
        {
            if (value && !ReturnedAt.HasValue)
                ReturnedAt = DateTime.UtcNow.AddHours(5);
            else if (!value)
                ReturnedAt = null;
        }
    }
    public DateTime? ReturnedAt { get; set; }


    public decimal FinePerDay { get; set; } = 2000;


    public decimal FineAmount {
        get
        {
            return CalculateFine();
        }
    }


    private decimal CalculateFine()
    {
        var compareDate = ReturnedAt?.Date ?? DateTime.UtcNow.AddHours(5).Date;

        int overdueDays = (compareDate - DueDate.Date).Days;

        if (overdueDays > 0)
        {
            return overdueDays * FinePerDay;
        }

        return 0;
    }
}
