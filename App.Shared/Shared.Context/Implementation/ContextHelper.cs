using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Shared.Context.Interface;
using Shared.Filters.ExceptionFilter;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Context.Implementation
{
    public class ContextHelper : IContextHelper
    {

        private IHttpContextAccessor _httpContextAccessor;
        private IConfiguration _configuration;
        public ContextHelper(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }
        public Guid GetUser()
        {
            try
            {
                string userId = GetRequestHeader()["Key"].ToString();
                if (string.IsNullOrEmpty(userId))
                    throw new UnauthorizedException("Unauthorized");
                else
                    return Guid.Parse(userId);
            }
            catch (Exception ex)
            {
                throw new UnauthorizedException("Unauthorized", ex);
            }
        }
        public Guid GetToken()
        {
            try
            {
                string accessToken = GetRequestHeader()["AccessToken"].ToString();
                if (string.IsNullOrEmpty(accessToken))
                {
                    throw new UnauthorizedException("Unauthorized");
                }
                else
                {
                    Guid token = Guid.Parse(accessToken);
                    return token;
                }
            }
            catch (Exception ex)
            {
                throw new UnauthorizedException("Unauthorized", ex);
            }
        }

        public Guid GetSession()
        {
            try
            {
                string sessionId = Convert.ToString(GetRequestHeader()["SessionId"]);
                if (string.IsNullOrEmpty(sessionId))
                    throw new UnauthorizedException("Unauthorized");
                else
                    return Guid.Parse(sessionId);
            }
            catch (Exception ex)
            {
                throw new UnauthorizedException("Unauthorized", ex);
            }
        }
        private JObject GetRequestHeader()
        {
            var AccessToken = Convert.ToString(_httpContextAccessor.HttpContext.Request.Headers["Authorization"]);
            dynamic jsonObject = new JObject();
            if (!string.IsNullOrEmpty(AccessToken))
            {
                AccessToken = AccessToken != null ? AccessToken.Split(' ')[1] : "";
                var stream = AccessToken;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(stream);
                var tokenDetail = handler.ReadToken(stream) as JwtSecurityToken;
                jsonObject.AccessToken = AccessToken;
                jsonObject.UserId = tokenDetail.Claims.First(claim => claim.Type == "Key").Value;
                jsonObject.SessionId = tokenDetail.Claims.First(claim => claim.Type == "Session").Value;
                return jsonObject;
            }
            return jsonObject;
        }
        public string GetClientIp()
        {
            return _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString();
        }
        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
