﻿using Assembly.MusicApp.Domain.Model;

namespace Assembly.MusicApp.Services
{
    public interface IUserService
    {
        List<User> GetAll();
    }
}
