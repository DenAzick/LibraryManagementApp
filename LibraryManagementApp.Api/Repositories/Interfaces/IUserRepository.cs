﻿using LibraryManagementApp.Api.Models;

namespace LibraryManagementApp.Api.Repositories.Interfaces
{
    public interface IUserRepository : IJsonRepository<User>
    {
        User? SearchByPassport(string passport);
    }
}
