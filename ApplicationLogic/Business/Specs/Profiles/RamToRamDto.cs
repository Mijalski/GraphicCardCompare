using ApplicationLogic.Business.Vendors;
using DomainLogic.Business.Specs;
using DomainLogic.Business.Vendors;

namespace ApplicationLogic.Business.Specs.Profiles
{
    public class RamToRamDto : AutoMapper.Profile
    {
        public RamToRamDto()
        {
            CreateMap<Ram, RamDto>();
        }
    }
}