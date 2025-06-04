using LibraryManagementApp.Models;
using System.Text.Json;
using System.Windows.Forms;

namespace LibraryManagementApp.Forms;

public partial class Books : Form
{
    public Books()
    {
        InitializeComponent();
    }

    private readonly HttpClient _httpClient = new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7243/")
    };

    private void Books_Load(object sender, EventArgs e)
    {
        textBoxName.PlaceholderText = "name";
        textBoxAuthor.PlaceholderText = "author";
        textBoxDescription.PlaceholderText = "description";
        textBoxISBN.PlaceholderText = "ISBN";
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
        catch(HttpRequestException ex)
        {
            MessageBox.Show("Сервер недоступен. Проверь, запущен ли API.\n" + ex.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }
}
