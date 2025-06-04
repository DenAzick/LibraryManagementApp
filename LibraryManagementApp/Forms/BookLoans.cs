using LibraryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementApp.Forms
{
    public partial class BookLoans : Form
    {
        public BookLoans()
        {
            InitializeComponent();
        }

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7243/")
        };

        private void BookLoans_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/BookLoan");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var loans = JsonSerializer.Deserialize<List<BookLoan>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    dataGridViewLoans.DataSource = loans;
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


        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string passport = textBoxPassport.Text.Trim();
            if (string.IsNullOrWhiteSpace(passport))
            {
                MessageBox.Show("Введите номер паспорта для поиска.");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"/api/User/search/passport?passport={passport}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var user = JsonSerializer.Deserialize<User>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (user == null || user.BookLoanId == null || user.BookLoanId.Count == 0)
                    {
                        MessageBox.Show("Книги не найдены.");
                        return;
                    }

                    var allLoansResponse = await _httpClient.GetAsync("/api/BookLoan");
                    if (allLoansResponse.IsSuccessStatusCode)
                    {
                        var loansJson = await allLoansResponse.Content.ReadAsStringAsync();
                        var allLoans = JsonSerializer.Deserialize<List<BookLoan>>(loansJson,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                        var userLoans = allLoans.Where(l => user.BookLoanId.Contains(l.Id)).ToList();
                        dataGridViewLoans.DataSource = userLoans;
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message);
            }
        }

        private async void buttonReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoans.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для возврата.");
                return;
            }

            var loan = dataGridViewLoans.CurrentRow.DataBoundItem as BookLoan;
            if (loan == null) return;

            var confirm = MessageBox.Show("Вы уверены, что хотите вернуть книгу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var response = await _httpClient.DeleteAsync($"/api/BookLoan/{loan.Id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Книга возвращена.");
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("Ошибка при возврате книги.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message);
            }
        }
    }
}
