using App.UserAPI.Common.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Service.Layer.Interfaces
{
    public interface IAccountService
    {
        bool Authenticate(UserLoginObj login);
        UserRegistration GetUser(UserLoginObj login);
        string GetUserHashPassword(UserLoginObj login);
        bool Register(UserRegistration register);
    }
}
