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

    public BookLoanController(IBookLoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_loanRepository.GetAll());

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
            BookId = loanDto.BookId,
            UserId = loanDto.UserId,
            BorrowedAt = DateTime.UtcNow.AddHours(5),
            DueDate = DateTime.UtcNow.AddDays(3),
            Returned = loanDto.Returned
        };



        _loanRepository.Add(loan);
        return Ok();
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
