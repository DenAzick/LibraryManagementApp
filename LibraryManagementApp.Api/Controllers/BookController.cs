using LibraryManagementApp.Api.Models;
using LibraryManagementApp.Api.Models.Dto;
using LibraryManagementApp.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookRepository _bookRepository;
    public BookController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_bookRepository.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var book = _bookRepository.GetById(id);
        return book == null ? NotFound() : Ok(book);
    }

    [HttpPost]
    public IActionResult Add(BookDto bookDto)
    {
        var book = new Book
        {
            Name = bookDto.Name,
            Description = bookDto.Description,
            Author = bookDto.Author,
            Year = bookDto.Year,
            Genre = bookDto.Genre,
            ISBN = bookDto.ISBN,
            Quantity = bookDto.Quantity,
            BookLoanId = new() 
        };

        _bookRepository.Add(book);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Book book)
    {
        if (id != book.Id)
            return BadRequest();

        _bookRepository.Update(book);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _bookRepository.Delete(id);
        return Ok();
    }

    [HttpGet("search/name")]
    public IActionResult SearchByName(string name) => Ok(_bookRepository.SearchByName(name));

    [HttpGet("search/author")]
    public IActionResult SearchByAuthor(string author) => Ok(_bookRepository.SearchByAuthor(author));

    [HttpGet("search/genre")]
    public IActionResult SearchByGenre(EGenre genre) => Ok(_bookRepository.SearchByGenre(genre));
}
