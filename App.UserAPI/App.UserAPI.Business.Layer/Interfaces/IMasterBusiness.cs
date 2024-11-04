using App.UserAPI.Common.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Business.Layer.Interfaces
{
    public interface IMasterBusiness
    {
        MasterData GetMasterActiveData();
    }
}
