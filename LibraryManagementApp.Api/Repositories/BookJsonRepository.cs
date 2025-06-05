using LibraryManagementApp.Api.Models;
using LibraryManagementApp.Api.Repositories.Interfaces;
using System.Text.Json;

namespace LibraryManagementApp.Api.Repositories;

public class BookJsonRepository : IBookRepository
{
    private readonly string _filePath = "Data/books.json";
    private List<Book> _books = new List<Book>();

    public BookJsonRepository()
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
        //if (_books.Any(b => b.Id == book.Id))
        //    throw new Exception("book with same Id already exists");

        if (_books.Count > 0)
            book.Id = _books.Max(b => b.Id) + 1;
        else
            book.Id = 1;

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


    public List<Book> SearchByName(string name)
    {
        return _books
            .Where(b => !string.IsNullOrEmpty(b.Name) && b.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }


    public List<Book> SearchByAuthor(string author)
    {
        return _books
            .Where(b => !string.IsNullOrEmpty(b.Author) && b.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Book> SearchByGenre(EGenre genre)
    {
        return _books.Where(b => b.Genre == genre).ToList();
    }
}
