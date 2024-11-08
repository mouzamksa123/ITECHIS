using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisDoctorSpecialityMapping
{
    public int DoctorSpecialityId { get; set; }

    public int DoctorId { get; set; }

    public int SpecialityId { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }
}
