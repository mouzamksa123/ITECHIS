using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisParameterType
{
    public int ParameterTypeId { get; set; }

    public string ParameterTypeName { get; set; } = null!;

    public string? ParameterTypeNameN { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual ICollection<HisParameter> HisParameters { get; } = new List<HisParameter>();
}
