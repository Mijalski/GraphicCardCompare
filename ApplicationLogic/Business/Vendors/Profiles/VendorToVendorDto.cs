using AutoMapper;
using DomainLogic.Business.Vendors;

namespace ApplicationLogic.Business.Vendors.Profiles
{
    public class VendorToVendorDto : AutoMapper.Profile
    {
        public VendorToVendorDto()
        {
            CreateMap<Vendor, VendorDto>();
        }
    }
}