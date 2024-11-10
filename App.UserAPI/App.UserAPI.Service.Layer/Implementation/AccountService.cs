using AutoMapper;
using App.UserAPI.Common.Layer.Models;
using App.UserAPI.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Entities.Infrastructure.Interface;
using Shared.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.UserAPI.Service.Layer.Implementation
{
    public class AccountService: IAccountService
    {
        private readonly IApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public AccountService(IApplicationDBContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public bool Authenticate(UserLoginObj login)
        {
            return true;
        }

        public UserRegistration GetUser(UserLoginObj login)
        {
            HisUser userLogin = _dbContext.UserLogins.AsNoTracking()
                .Where(x => x.UserName.Trim().ToLower() == login.UserLogin.Trim()).FirstOrDefault();
            UserRegistration userRegistration = _mapper.Map<HisUser ,UserRegistration>(userLogin);
            return userRegistration;
        }

        public string GetUserHashPassword(UserLoginObj login)
        {
            throw new NotImplementedException();
        }

        public bool Register(UserRegistration register)
        { 
            HisUser userLogin = _mapper.Map<UserRegistration, HisUser>(register);
            userLogin.UserId = 1;
            userLogin.IsActive = true;
            userLogin.CreatedOn = DateTime.Now;
            userLogin.CreatedBy = userLogin.UserId;
            _dbContext.UserLogins.Add(userLogin);
            _dbContext.SaveChanges();
            return true;
        }

        public IList<PatientViewModel> GetPatients()
        {
            IList<HisPatientId> patientIds = _dbContext.PatientIds.AsNoTracking()
                .ToList();            
            IList<PatientViewModel> patientView = _mapper.Map<IList<HisPatientId>, IList<PatientViewModel>>(patientIds);
            return patientView;
        }
    }
}
