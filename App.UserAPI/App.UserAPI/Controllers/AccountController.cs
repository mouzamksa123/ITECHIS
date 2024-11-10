using App.UserAPI.Business.Layer.Interfaces;
using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Helpers.AlertMessages;
using App.UserAPI.Helpers.AppSettings;
using App.UserAPI.Helpers.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Shared.Context.Interface;
using Shared.Encryption.Interface;
using Shared.Filters.ExceptionFilter;
using System;
using System.Threading.Tasks;

namespace App.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppSetting _appSettings;
        private readonly IContextHelper _contextHelper;
        private readonly IAccountBusiness _accountBusiness;
        private readonly IPasswordHasher _passwordHasher;
        public AccountController(IAccountBusiness accountBusiness,IOptions<AppSetting> appSettings
            , IContextHelper contextHelper
            , IPasswordHasher passwordHasher)
        {
            _accountBusiness=accountBusiness;
            _appSettings = appSettings.Value;
            _contextHelper = contextHelper;
            _passwordHasher = passwordHasher;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm]UserLoginObj login)
        {
            if (login!=null && !string.IsNullOrWhiteSpace(login.UserLogin) && !string.IsNullOrWhiteSpace(login.UserPassword))
            {
                string userHashPassword = _accountBusiness.GetUserHashPassword(login);
                UserLoginResponse _login = new UserLoginResponse();
                if (!string.IsNullOrWhiteSpace(userHashPassword) && _passwordHasher.Check(userHashPassword,login.UserPassword).Verified)
                {
                    _login.Status = true;
                    _login = GenrateToken.TokenGenration(Guid.Empty, _appSettings, _contextHelper.GetClientIp());

                    // Save Session Log
                    if (true)
                    {
                        return Ok(_login);
                    }
                }
                else
                {
                    throw new CustomException(AlertMessage.InvalidLogin);
                }
            }
            else
            {
                throw new CustomException(AlertMessage.InvalidRequest);
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm]UserRegistration register)
        {
            if (register != null)
            {
                register.LoginPassword = _passwordHasher.Hash(register.LoginPassword);
                if (_accountBusiness.Register(register))
                {
                    UserLoginResponse _login = new UserLoginResponse();
                    _login.Status = _accountBusiness.Authenticate(new UserLoginObj { UserLogin = register.UserLoginName, UserPassword = register.LoginPassword });
                    if (_login.Status)
                    {
                        _login = GenrateToken.TokenGenration(Guid.Empty, _appSettings, _contextHelper.GetClientIp());

                        if (true)
                        {
                            return Ok(_login);
                        }
                    }
                }
            }
            return null;
        }
    }
}
