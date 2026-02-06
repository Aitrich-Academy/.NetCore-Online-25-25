using AutoMapper;
using MvcWorkshopHireMe.Dto;
using MvcWorkshopHireMe.Models;

namespace MvcWorkshopHireMe.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<JobDto, Job>().ReverseMap();

            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<CompanyMemberDto, User>().ReverseMap();
        }
    }
}

