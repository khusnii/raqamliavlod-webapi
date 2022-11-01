﻿using Microsoft.AspNetCore.Http;
using RaqamliAvlod.Domain.Entities.Users;

namespace RaqamliAvlod.Application.ViewModels.Users.Commands
{
    public class UserUpdateViewModel
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public IFormFile? Image { get; set; }

        public static implicit operator UserUpdateViewModel(User user)
        {
            return new UserUpdateViewModel()
            {
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
                Password = user.PasswordHash
            };
        }
    }


}
