using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }
}
