namespace LibraryManagementApp.Api.Models;

public class Library
{
    public int Id { get; set; } = 1;
    public string Name { get; set; } = "Alisher Navoi";
    public string Adsress { get; set; } = "Tashkent";

    public List<User> Users { get; set; } = new List<User>();
    public List<Book> Books { get; set; } = new List<Book>();

}
