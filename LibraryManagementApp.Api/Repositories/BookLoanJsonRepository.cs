using LibraryManagementApp.Api.Models;
using LibraryManagementApp.Api.Repositories.Interfaces;
using System.Text.Json;

namespace LibraryManagementApp.Api.Repositories;

public class BookLoanJsonRepository : IBookLoanRepository
{
    private readonly string _filePath = "Data/bookLoan.json";
    private List<BookLoan> _bookLoans = new List<BookLoan>();

    public BookLoanJsonRepository()
    {
        Load();
    }

    private void Load()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            _bookLoans = JsonSerializer.Deserialize<List<BookLoan>>(json) ?? new List<BookLoan>();
        }
    }

    private void Save()
    {
        var json = JsonSerializer.Serialize(_bookLoans, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }


    public void Add(BookLoan loan)
    {

        if (_bookLoans.Any(l => l.Id == loan.Id))
            throw new Exception("Loan with same ID already exists.");

        _bookLoans.Add(loan);
        Save();
    }

    public void Delete(int id)
    {
        var loan = GetById(id);
        if (loan == null) throw new Exception("Loan not found.");

        _bookLoans.Remove(loan);
        Save();
    }

    public List<BookLoan> GetAll()
    {
        return _bookLoans;
    }

    public BookLoan? GetById(int id)
    {
        return _bookLoans.FirstOrDefault(x => x.Id == id);
    }

    public void Update(BookLoan loan)
    {
        var index = _bookLoans.FindIndex(l => l.Id == loan.Id);
        if (index == -1)
            throw new Exception("Loan not found.");

        _bookLoans[index] = loan;
        Save();
    }
}
