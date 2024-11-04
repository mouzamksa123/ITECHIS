using App.UserAPI.Business.Layer.Interfaces;
using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Business.Layer.Implementation
{
    public class AccountBusiness : IAccountBusiness
    {
        private readonly IAccountService _accountService;
        public AccountBusiness(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public bool Authenticate(UserLoginObj login)
        {
            return _accountService.Authenticate(login);
        }

        public UserRegistration GetUser(UserLoginObj login)
        {
            return _accountService.GetUser(login);
        }

        public string GetUserHashPassword(UserLoginObj login)
        {
            UserRegistration userRegistration = _accountService.GetUser(login);
            return userRegistration!=null?userRegistration.LoginPassword:String.Empty;
        }

        public bool Register(UserRegistration register)
        {
            return _accountService.Register(register);
        }
    }
}
