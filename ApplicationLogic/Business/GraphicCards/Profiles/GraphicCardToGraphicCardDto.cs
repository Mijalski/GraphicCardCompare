using ApplicationLogic.Business.Specs;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Specs;

namespace ApplicationLogic.Business.GraphicCards.Profiles
{
    public class GraphicCardToGraphicCardDto : AutoMapper.Profile
    {
        public GraphicCardToGraphicCardDto()
        {
            CreateMap<GraphicCard, GraphicCardDto>()
                .ForMember(dst => dst.RamCapacity, opt => opt.MapFrom(src => src.Ram.Capacity))
                .ForMember(dst => dst.RamType, opt => opt.MapFrom(src => src.Ram.TypeOfRam))
                .ForMember(dst => dst.VendorName, opt => opt.MapFrom(src => src.Vendor.Name));
        }
    }
}