using LibraryManagementApp.Forms;
using LibraryManagementApp.Models;
using System.Text.Json;

namespace LibraryManagementApp;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private readonly HttpClient _httpClient = new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7243/")
    };

    private void Main_Load(object sender, EventArgs e)
    {
        textBoxName.PlaceholderText = "Name";
        textBoxAuthor.PlaceholderText = "Author";
        textBoxGenre.PlaceholderText = "Genre";
        LoadData();
    }

    private async void LoadData()
    {
        try
        {
            var response = await _httpClient.GetAsync("/api/Book");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<Book>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridViewBooks.DataSource = books;
            }
            else
                MessageBox.Show($"Ошибка: {response.StatusCode}");
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show("Сервер недоступен. Проверь, запущен ли API.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }

    private void buttonManager_Click(object sender, EventArgs e)
    {
        var bookManager = new Books();
        bookManager.ShowDialog();
    }

    private void buttonUserManager_Click(object sender, EventArgs e)
    {
        var userManager = new Users();
        userManager.ShowDialog();
    }

    private void buttonLoans_Click(object sender, EventArgs e)
    {
        var loansManager = new BookLoans();
        loansManager.ShowDialog();
    }

    private async void buttonSearchName_Click(object sender, EventArgs e)  //name search
    {
        try
        {
            string name = textBoxName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название книги для поиска.");
                return;
            }
            var response = await _httpClient.GetAsync($"/api/Book/search/name?name={Uri.EscapeDataString(name)}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<Book>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridViewBooks.DataSource = books;
            }
            else
                MessageBox.Show($"Ошибка: {response.StatusCode}");
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show("Сервер недоступен. Проверь, запущен ли API.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }

    private async void buttonSearchGenre_Click(object sender, EventArgs e)  //search genre
    {
        try
        {
            string genre = textBoxGenre.Text.Trim();

            if (string.IsNullOrWhiteSpace(genre))
            {
                MessageBox.Show("Введите название книги для поиска.");
                return;
            }
            var response = await _httpClient.GetAsync($"/api/Book/search/genre?genre={Uri.EscapeDataString(genre)}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<Book>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridViewBooks.DataSource = books;
            }
            else
                MessageBox.Show($"Ошибка: {response.StatusCode}");
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show("Сервер недоступен. Проверь, запущен ли API.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }

    private async void buttonSearchAuthor_Click(object sender, EventArgs e)
    {
        try
        {
            string author = textBoxAuthor.Text.Trim();

            if (string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Введите название книги для поиска.");
                return;
            }
            var response = await _httpClient.GetAsync($"/api/Book/search/author?author={Uri.EscapeDataString(author)}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<Book>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridViewBooks.DataSource = books;
            }
            else
                MessageBox.Show($"Ошибка: {response.StatusCode}");
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show("Сервер недоступен. Проверь, запущен ли API.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }
}
