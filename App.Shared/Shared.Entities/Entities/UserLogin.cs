using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class UserLogin
{
    public Guid UserLoginId { get; set; }

    public string UserLoginName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? UserEmail { get; set; }

    public Guid CountryCodeId { get; set; }

    public long UserMobile { get; set; }

    public string LoginPassword { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
