using Microsoft.IdentityModel.Tokens;
using App.UserAPI.Helpers.AppSettings;
using App.UserAPI.Common.Layer.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace App.UserAPI.Helpers.JWT
{
    public static class GenrateToken
    {
        public static UserLoginResponse TokenGenration(Guid userLoginId, AppSetting appSettings, string ipAddress)
        {
            try
            {
                UserLoginResponse login = new UserLoginResponse { UserLoginId= userLoginId };
                login.SessionId = Guid.NewGuid();
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(appSettings.JWTSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                         new Claim("Key", login.UserLoginId.ToString()),
                         new Claim("SessionId", login.SessionId.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(appSettings.JWTSettings.Expires),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);

                login.UserToken = tokenHandler.WriteToken(token);
                login.UserLoginDateTime = DateTime.Now;
                login.Status = true;
                login.HostName = ipAddress;
                login.Ipaddress = ipAddress;
                return login;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
