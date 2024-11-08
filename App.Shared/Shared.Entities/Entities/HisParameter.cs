using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisParameter
{
    public int ParameterId { get; set; }

    public int ParameterTypeId { get; set; }

    public string ParameterName { get; set; } = null!;

    public string? ParameterNameN { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }

    public virtual HisParameterType ParameterType { get; set; } = null!;
}
