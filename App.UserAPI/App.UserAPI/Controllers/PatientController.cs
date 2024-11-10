using App.UserAPI.Business.Layer.Implementation;
using App.UserAPI.Business.Layer.Interfaces;
using App.UserAPI.Common.Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace App.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public readonly IPatientBusiness _patientBusiness;
        public PatientController(IPatientBusiness patientBusiness)
        {
            _patientBusiness = patientBusiness;
        }
        [HttpGet("getPatients")]
        public async Task<IActionResult> GetPatients()
        {
            var patient = _patientBusiness.GetPatients();
            if (patient != null)             
                return Ok(patient);                        
            else           
                return NotFound();                        
        }
        [HttpPost("savePatient")]
        public IActionResult SavePetient([FromForm] PatientViewModel patient)
        {
            if(_patientBusiness.SavePatient(patient))
            return Ok(true);
            else
                return BadRequest();
        }
        [HttpPatch("updatePatient")]
        public IActionResult UpdatePatient([FromForm] PatientViewModel patient)
        {
            var newPatientID=_patientBusiness.UpdatePatient(patient);
            if (newPatientID > 0)
                return Ok(newPatientID);
            else return BadRequest();
        }
    }
}
