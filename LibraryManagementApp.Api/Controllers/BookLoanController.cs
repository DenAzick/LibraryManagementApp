using LibraryManagementApp.Api.Models;
using LibraryManagementApp.Api.Models.Dto;
using LibraryManagementApp.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookLoanController : ControllerBase
{
    private readonly IBookLoanRepository _loanRepository;
    private readonly IUserRepository _userRepository;
    private readonly IBookRepository _bookRepository;

    public BookLoanController(IBookLoanRepository loanRepository, IUserRepository userRepository, IBookRepository bookRepository)
    {
        _loanRepository = loanRepository;
        _userRepository = userRepository;
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var loans = _loanRepository.GetAll();
        var books = _bookRepository.GetAll();
        var users = _userRepository.GetAll();

        var now = DateTime.UtcNow.AddHours(5);

        var loanDtos = loans.Select(loan =>
        {
            var book = books.FirstOrDefault(b => b.Id == loan.BookId);
            var user = users.FirstOrDefault(u => u.Id == loan.UserId);

            DateTime returnDate = loan.ReturnedAt ?? now;
            int overdueDays = (returnDate.Date - loan.DueDate.Date).Days;
            decimal fine = overdueDays > 0 ? overdueDays * loan.FinePerDay : 0;

            return new BookLoanDto
            {
                Id = loan.Id,
                BookTitle = book?.Name ?? "",
                UserFullName = $"{user?.FName ?? ""} {user?.LName ?? ""}".Trim(),
                LoanDate = loan.BorrowedAt,
                DueDate = loan.DueDate,
                ReturnDate = loan.ReturnedAt,
                FineAmount = fine,
                
                
            };
        }).ToList();

        return Ok(loanDtos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var loan = _loanRepository.GetById(id);
        return loan == null ? NotFound() : Ok(loan);
    }

    [HttpPost]
    public IActionResult Add(BookLoanDto loanDto)
    {
        var loan = new BookLoan
        {
            Id = loanDto.Id,
            //BookId = loanDto.BookId,
            //UserId = loanDto.UserId,
            BorrowedAt = DateTime.UtcNow.AddHours(5),
            DueDate = DateTime.UtcNow.AddDays(3),
            Returned = loanDto.Returned
        };



        _loanRepository.Add(loan);
        return Ok();
    }

    [HttpPut("{id}/return")]
    public IActionResult ReturnBook(int id)
    {
        var loan = _loanRepository.GetById(id);
        if (loan == null)
            return NotFound("Запись не найдена.");

        if (loan.Returned)
            return BadRequest("Книга уже возвращена.");

        loan.Returned = true; 
        _loanRepository.Update(loan);

        return Ok(new
        {
            message = "Книга успешно возвращена",
            returnedAt = loan.ReturnedAt
        });
    }


    [HttpPut("{id}")]
    public IActionResult Update(int id, BookLoan loan)
    {
        if (id != loan.Id)
            return BadRequest();

        _loanRepository.Update(loan);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _loanRepository.Delete(id);
        return Ok();
    }
}
