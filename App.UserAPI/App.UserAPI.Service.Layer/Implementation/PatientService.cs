using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shared.Entities.Entities;
using Shared.Entities.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Service.Layer.Implementation
{
    public class PatientService:IPatientService
    {
        private readonly IApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public PatientService(IApplicationDBContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public IList<PatientViewModel> GetPatients()
        {
            IList<HisPatientId> patientIds = _dbContext.PatientIds.AsNoTracking()
                .ToList();
            IList<PatientViewModel> patientView = _mapper.Map<IList<HisPatientId>, IList<PatientViewModel>>(patientIds);
            return patientView;
        }
        public bool SavePatient(PatientViewModel patient)
        {
            HisPatientId objPatient = _mapper.Map<PatientViewModel, HisPatientId>(patient);
            _dbContext.PatientIds.Add(objPatient);
            _dbContext.SaveChanges();
            return true;
        }
        public int UpdatePatien(PatientViewModel patient)
        {
            var objPatient = _dbContext.PatientIds.Find(patient.PatientId);
            if (objPatient != null)
            {
                objPatient = _mapper.Map<PatientViewModel, HisPatientId>(patient);
                _dbContext.PatientIds.Update(objPatient);
                _dbContext.SaveChanges();
                return objPatient.PatientId;
            }
            return 0;

        }
    }
}
