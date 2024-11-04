using App.UserAPI.Business.Layer.Interfaces;
using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Business.Layer.Implementation
{
    public class MasterBusiness : IMasterBusiness
    {
        private readonly IMasterService _masterService;
        public MasterBusiness(IMasterService masterService)
        {
            _masterService = masterService;
        }

        public MasterData GetMasterActiveData()
        {
            MasterData masterData = new MasterData();
            masterData.Gender = _masterService.GetGender(true);
            return masterData;
        }
    }
}
