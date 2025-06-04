using LibraryManagementApp.Api.Models;

namespace LibraryManagementApp.Api.Repositories.Interfaces
{
    public interface IBookRepository : IJsonRepository<Book>
    {
        List<Book> SearchByName(string name);
        List<Book> SearchByAuthor(string author);
        List<Book> SearchByGenre(EGenre genre);
    }
}
