using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisDoctorSchedule
{
    public int ScheduleId { get; set; }

    public int DoctorId { get; set; }

    public int WeekDayId { get; set; }

    public string SlotDuration { get; set; } = null!;

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }
}
