using System;
using System.Collections.Generic;

namespace Shared.Entities.Entities;

public partial class HisDoctor
{
    public int DoctorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNumber { get; set; }

    public string? EmergencyContactName { get; set; }

    public string? EmergencyContactNumber { get; set; }

    public int? AreaId { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public string? Address { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? EditedBy { get; set; }

    public DateTime? EditedOn { get; set; }
}
