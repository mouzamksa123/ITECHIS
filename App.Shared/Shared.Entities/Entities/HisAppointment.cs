using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisAppointment
{
    public long AppointmentNo { get; set; }

    public int? AppointmentType { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public int? PatientId { get; set; }

    public int? DoctorId { get; set; }

    public int? ClinicId { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public short? Status { get; set; }

    public short? VisitType { get; set; }

    public short? PatientArrivalStatusType { get; set; }

    public TimeSpan? ActualVisitStartTime { get; set; }

    public TimeSpan? ActualVisitEndTime { get; set; }

    public int? BookedBy { get; set; }

    public DateTime? BookedOn { get; set; }

    public int? ConfirmedBy { get; set; }

    public DateTime? ConfirmedIon { get; set; }

    public int? ArrivedBy { get; set; }

    public DateTime? ArrivedOn { get; set; }

    public int? RescheduledBy { get; set; }

    public DateTime? RescheduledOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public string? E { get; set; }
}
