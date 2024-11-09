using AutoMapper;
using App.UserAPI.Common.Layer.Models;
using Shared.Entities.Entities;

namespace App.UserAPI.Helpers.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistration, HisUser>();
            CreateMap<HisUser, UserRegistration>();
        }
    }
}
