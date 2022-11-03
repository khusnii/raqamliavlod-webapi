﻿using Microsoft.Extensions.Caching.Memory;
using RaqamliAvlod.DataAccess.Interfaces.Users;
using RaqamliAvlod.DataAccess.Repositories.Users;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Infrastructure.Service.Services.Users
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _repositroy;
        private readonly IFileService _fileservice;
        private readonly IAuthManager _authManager;
        private readonly IMemoryCache _cache;
        private readonly IEmailService _emailService;

        public AccountService(IUserRepository userRepository, IFileService fileService, IAuthManager authManager,
            IMemoryCache cache, IEmailService emailService)
        {
            _repositroy = userRepository;
            _fileservice = fileService;
            _authManager = authManager;
            _cache = cache;
            _emailService = emailService;
        }

        public async Task<string> LogInAsync(AccountLoginDto accountLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync(AccountCreateDto accountCreate)
        {
            throw new NotImplementedException();
        }

        public Task SendCodeAsync(SendToEmailDto sendToEmail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyEmailAsync(VerifyEmailDto verifyEmail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyPasswordAsync(UserResetPasswordDto userResetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
