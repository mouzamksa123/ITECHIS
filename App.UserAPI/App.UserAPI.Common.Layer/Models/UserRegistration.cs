using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Common.Layer.Models
{
    public class UserRegistration
    {
        public string UserLoginName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

        public string UserEmail { get; set; }

        public Guid CountryCodeId { get; set; }

        public long UserMobile { get; set; }

        public string LoginPassword { get; set; }
    }
}
