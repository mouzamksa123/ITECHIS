using Microsoft.EntityFrameworkCore;
using Shared.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities.Infrastructure.Interface
{
    public interface IApplicationDBContext
    {
        public DbSet<HisUser> UserLogins { get; set; }
        public DbSet<HisPatientId> PatientIds { get; set; }
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
