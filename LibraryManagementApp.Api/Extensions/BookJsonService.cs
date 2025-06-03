using LibraryManagementApp.Api.Models;
using System.Text.Json;

namespace LibraryManagementApp.Api.Extensions;

public class BookJsonService : IJsonService<Book>
{
    private readonly string _filePath = "Data/books.json";
    private List<Book> _books = new List<Book>();

    public BookJsonService()
    {
        Load();
    }

    private void Load()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            if (string.IsNullOrEmpty(json))
                _books = new List<Book>();

            else
                _books = JsonSerializer.Deserialize<List<Book>>(json);
        }
    }
    private void Save()
    {
        var json = JsonSerializer.Serialize(_books, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }


    public void Add(Book book)
    {
        if (_books.Any(b => b.Id == book.Id))
            throw new Exception("book with same Id already exists");

        _books.Add(book);
        Save();
    }

    public void Delete(int id)
    {
        var book = GetById(id);
        if (book == null)
            throw new Exception("book not found");
        
        _books.Remove(book);
        Save();
    }

    public List<Book> GetAll()
    {
        return _books;
    }

    public Book? GetById(int id)
    {
        return _books.FirstOrDefault(x => x.Id == id);
    }

    public void Update(Book book)
    {
        var index = _books.FindIndex(b => b.Id == book.Id);
        if (index == -1)
            throw new Exception("Book not found.");

        _books[index] = book;
        Save();
    }
}
