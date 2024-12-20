﻿using AutoMapper;
using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Entities.Infrastructure.Interface;
using Shared.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.UserAPI.Service.Layer.Implementation
{
    public class AccountService: IAccountService
    {
        private readonly IApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public AccountService(IApplicationDBContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public bool Authenticate(UserLoginObj login)
        {
            return true;
        }

        public UserRegistration GetUser(UserLoginObj login)
        {
            UserLogin userLogin = _dbContext.UserLogins.AsNoTracking()
                .Where(x => x.UserLoginName.Trim().ToLower() == login.UserLogin.Trim()).FirstOrDefault();
            UserRegistration userRegistration = _mapper.Map<UserLogin ,UserRegistration>(userLogin);
            return userRegistration;
        }

        public string GetUserHashPassword(UserLoginObj login)
        {
            throw new NotImplementedException();
        }

        public bool Register(UserRegistration register)
        { 
            UserLogin userLogin = _mapper.Map<UserRegistration, UserLogin>(register);
            userLogin.UserLoginId = Guid.NewGuid();
            userLogin.IsActive = true;
            userLogin.CreatedOn = DateTime.Now;
            userLogin.CreatedBy = userLogin.UserLoginId;
            _dbContext.UserLogins.Add(userLogin);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
