using AutoMapper;
using ReactivitiesDomain;

namespace ReactivitiesApplication.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
        }
    }
}
