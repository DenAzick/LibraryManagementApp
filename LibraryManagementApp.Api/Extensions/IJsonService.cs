namespace LibraryManagementApp.Api.Extensions;

public interface IJsonService<T>
{
    List<T> GetAll();
    T? GetById(int id);
    void Add(T item);
    void Update(T item);
    void Delete(int id);
}
