using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Common.Layer.Models
{
    public class UserLoginResponse
    {

        public Guid SessionId { get; set; } 
        public Guid UserLoginId { get; set; }
        public string UserToken { get; set; }
        public DateTime? UserLoginDateTime { get; set; }
        public DateTime? UserLogoutDateTime { get; set; }
        public bool Status { get; set; }
        public string HostName { get; set; }
        public string Ipaddress { get; set; }
        public string DomainName { get; set; }
        public string AppVersion { get; set; }
        public string Macaddress { get; set; }
    }
}
