using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Entities.Infrastructure.Interface;

namespace App.UserAPI.Service.Layer.Implementation
{
    public class MasterService : IMasterService
    {
        private readonly IApplicationDBContext _dbContext;
        public MasterService(IApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<KeyValueSet> GetGender(bool? isActive)
        {
            try
            {
                //var genderList =  (from gender in _dbContext.MasGenders.Where(x=>x.IsActive ==(isActive == null ? x.IsActive : isActive))
                //                   select new KeyValueSet
                //                   {
                //                       Id = gender.GenderId,
                //                       Value = gender.Name,
                //                       IsActive = gender.IsActive
                //                   }); 
                //return  genderList;
                return new List<KeyValueSet>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
