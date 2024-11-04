using Microsoft.AspNetCore.Mvc;
using App.UserAPI.Business.Layer.Interfaces;
using App.UserAPI.Common.Layer.Models;

namespace App.UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : Controller
    {
        private readonly IMasterBusiness _masterBusiness;
        public MasterController(IMasterBusiness masterBusiness)
        {
            _masterBusiness = masterBusiness;
        }
        [HttpGet("GetMasterData")]
        public  MasterData GetMasterData()
        {
            return _masterBusiness.GetMasterActiveData();
        }
    }
}
