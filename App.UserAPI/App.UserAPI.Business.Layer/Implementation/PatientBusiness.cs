using App.UserAPI.Business.Layer.Interfaces;
using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Implementation;
using App.UserAPI.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Business.Layer.Implementation
{
    public class PatientBusiness:IPatientBusiness
    {
        private readonly IPatientService _patientService;
        public PatientBusiness(IPatientService patientService)
        {
            _patientService = patientService;
        }
        public IList<PatientViewModel> GetPatients()
        {
            IList<PatientViewModel> patientViewModel = _patientService.GetPatients();
            return patientViewModel;
        }
        public bool SavePatient(PatientViewModel patient)
        {
            return _patientService.SavePatient(patient);
        }
        public int UpdatePatient(PatientViewModel patient)
        {
            return _patientService.UpdatePatien(patient);
        }
    }
}
