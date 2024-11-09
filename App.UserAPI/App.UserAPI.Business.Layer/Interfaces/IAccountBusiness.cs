using App.UserAPI.Common.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Business.Layer.Interfaces
{
    public interface IAccountBusiness
    {
        bool Authenticate(UserLoginObj login);
        UserRegistration GetUser(UserLoginObj login);
        string GetUserHashPassword(UserLoginObj login);
        bool Register(UserRegistration register);
        IList<PatientViewModel> GetPatients();
    }
}
