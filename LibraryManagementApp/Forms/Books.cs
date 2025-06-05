using LibraryManagementApp.Models;
using System.Text;
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
        comboBoxGenre.DataSource = Enum.GetValues(typeof(EGenre));
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

    private async void buttonAddBook_Click(object sender, EventArgs e)
    {
        var books = new Book
        {
            Name = textBoxName.Text,
            Author = textBoxAuthor.Text,
            Description = textBoxDescription.Text,
            ISBN = textBoxISBN.Text,
            Genre = (EGenre)comboBoxGenre.SelectedItem,
            Year = dateTimePickerBook.Value
        };

        var json = JsonSerializer.Serialize(books);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.PostAsync("/api/Book/", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("книга добавлена");
                LoadData();
                textBoxAuthor.Clear();
                textBoxDescription.Clear();
                textBoxISBN.Clear();
                textBoxName.Clear();
            }
            else
            {
                var errorText = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Ошибка: {response.StatusCode}\n{errorText}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }

    }

    private async void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewBooks.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите книгу для удаления");
            return;
        }

        var selectedBook = (Book)dataGridViewBooks.SelectedRows[0].DataBoundItem;

        if (MessageBox.Show($"Вы уверены, что хотите удалить книгу '{selectedBook.Name}'?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }

        try
        {
            var response = await _httpClient.DeleteAsync($"/api/Book/{selectedBook.Id}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Книга успешно удалена");
                LoadData();
            }
            else
            {
                var errorText = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Ошибка: {response.StatusCode}\n{errorText}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }

    private async void buttonEdit_Click(object sender, EventArgs e)  //not working
    {
        if (dataGridViewBooks.SelectedRows.Count == 0)
        {
            MessageBox.Show("Выберите книгу для редактирования");
            return;
        }

        var selectedBook = (Book)dataGridViewBooks.SelectedRows[0].DataBoundItem;

        var updatedBook = new Book
        {
            Id = selectedBook.Id,
            Name = textBoxName.Text,
            Author = textBoxAuthor.Text,
            Description = textBoxDescription.Text,
            ISBN = textBoxISBN.Text,
            Genre = (EGenre)comboBoxGenre.SelectedItem,
            Year = dateTimePickerBook.Value
        };

        var json = JsonSerializer.Serialize(updatedBook);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.PutAsync($"/api/Book/{selectedBook.Id}", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Книга успешно обновлена");
                LoadData();
                ClearForm();
            }
            else
            {
                var errorText = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Ошибка: {response.StatusCode}\n{errorText}");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка:\n" + ex.Message);
        }
    }
    private void ClearForm()
    {
        textBoxName.Clear();
        textBoxAuthor.Clear();
        textBoxDescription.Clear();
        textBoxISBN.Clear();
        comboBoxGenre.SelectedIndex = 0;
        dateTimePickerBook.Value = DateTime.Now;
    }
}
