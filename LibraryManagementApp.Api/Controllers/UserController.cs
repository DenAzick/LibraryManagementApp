using LibraryManagementApp.Api.Models;
using LibraryManagementApp.Api.Models.Dto;
using LibraryManagementApp.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_userRepository.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _userRepository.GetById(id);
        return user == null ? NotFound() : Ok(user);
    }

    [HttpPost]
    public IActionResult Add(UserDto userDto)
    {
        var user = new User
        {
            FName = userDto.FName,
            LName = userDto.LName,
            PasswordHash = userDto.PasswordHash,
            PhoneNumber = userDto.PhoneNumber,
            Address = userDto.Address,
            Passport = userDto.Passport,
            Email = userDto.Email,
            Role = userDto.Role,
            CreatedAt = DateTime.UtcNow.AddHours(5),
            BookLoanId = new List<int>()
        };
        _userRepository.Add(user);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, User user)
    {
        if (id != user.Id)
            return BadRequest();

        _userRepository.Update(user);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _userRepository.Delete(id);
        return Ok();
    }

    [HttpGet("search/passport")]
    public IActionResult SearchByPassport(string passport)
    {
        var user = _userRepository.SearchByPassport(passport);
        return user == null ? NotFound() : Ok(user);
    }
}
