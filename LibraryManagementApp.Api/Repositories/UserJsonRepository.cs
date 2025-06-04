using LibraryManagementApp.Api.Models;
using LibraryManagementApp.Api.Repositories.Interfaces;
using System.Text.Json;

namespace LibraryManagementApp.Api.Repositories
{
    public class UserJsonRepository : IUserRepository
    {
        private readonly string _filePath = "Data/users.json";
        private List<User> _users = new();

        public UserJsonRepository()
        {
            Load();
        }


        private void Load()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                if (string.IsNullOrEmpty(json)) 
                    _users = new List<User>();
                
                else 
                    _users = JsonSerializer.Deserialize<List<User>>(json);
            }
        }

        private void Save()
        {
            var json = JsonSerializer.Serialize(_users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(_filePath, json); 
        }


        public void Add(User user)
        {
            //if (_users.Any(u => u.Id == user.Id || u.Username == user.Username))
            //    throw new Exception("user with same Id or Username already exists");

            int newId = 1;
            if (_users.Count > 0)
            {
                newId = _users.Max(u => u.Id) + 1;
            }
            user.Id = newId;

            if (!string.IsNullOrEmpty(user.Username) && _users.Any(u => u.Username == user.Username))
                throw new Exception("User with same Username already exists");

            _users.Add(user);
            Save();
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user == null) throw new Exception("User not found.");

            _users.Remove(user);
            Save();
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public User? GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(User user)
        {
            var index = _users.FindIndex(u => u.Id == user.Id);
            if (index == -1)
                throw new Exception("User not found.");

            _users[index] = user;
            Save();
        }


        public User? SearchByPassport(string passport)
        {
            return _users
                .FirstOrDefault(u => !string.IsNullOrEmpty(u.Passport) &&
                                     u.Passport.Equals(passport, StringComparison.OrdinalIgnoreCase));
        }

    }
}
