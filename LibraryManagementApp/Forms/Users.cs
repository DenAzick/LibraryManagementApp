using LibraryManagementApp.Models;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace LibraryManagementApp.Forms;

public partial class Users : Form
{
    public Users()
    {
        InitializeComponent();
    }

    private readonly HttpClient _httpClient = new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7243/")
    };
    private void Users_Load(object sender, EventArgs e)
    {
        LoadData();
        textBoxFName.PlaceholderText = "firstname";
        textBoxLName.PlaceholderText = "lastname";
        textBoxPassport.PlaceholderText = "password";
        textBoxPhoneNumber.PlaceholderText = "phone number";
    }
    private async void LoadData()
    {
        try
        {
            var response = await _httpClient.GetAsync("/api/User");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var books = JsonSerializer.Deserialize<List<User>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dataGridViewUsers.DataSource = books;
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

    private async void buttonAddUser_Click(object sender, EventArgs e)
    {
        var user = new User
        {
            FName = textBoxFName.Text.Trim(),
            LName = textBoxLName.Text.Trim(),
            Passport = textBoxPassport.Text.Trim(),
            PhoneNumber = textBoxPhoneNumber.Text.Trim()
        };

        var json = JsonSerializer.Serialize(user);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            var response = await _httpClient.PostAsync("/api/User", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Пользователь добавлен!");
                LoadData(); 
                textBoxFName.Clear();
                textBoxLName.Clear();
                textBoxPassport.Clear();
                textBoxPhoneNumber.Clear();
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
}
