using Microsoft.EntityFrameworkCore;
using Shared.Entities.Entities;
using Shared.Entities.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities.Entities
{
    public partial class ItechisCoreContext : DbContext, IApplicationDBContext
    {
        #region DbSet
        //public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<HisUser> UserLogins { get; set; }
        public virtual DbSet<HisPatientId> PatientIds { get; set; }
        #endregion
        #region Methods
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        public int SaveChanges()
        {
            return base.SaveChanges();
        }
        #endregion

    }
}
