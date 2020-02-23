using ApplicationLogic.Business.GraphicCards;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Vendors;

namespace ApplicationLogic.Business.Vendors.Profiles
{
    public class VendorDtoToVendor : AutoMapper.Profile
    {
        public VendorDtoToVendor()
        {
            CreateMap<VendorDto, Vendor>()
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}