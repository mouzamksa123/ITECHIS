using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisDoctorCalender
{
    public int DoctorCalenderId { get; set; }

    public int DoctorId { get; set; }

    public int ClinicId { get; set; }

    public DateTime? GregDate { get; set; }

    public int? SlotDuration { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }
}
