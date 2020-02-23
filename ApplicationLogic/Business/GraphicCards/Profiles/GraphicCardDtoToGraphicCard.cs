using ApplicationLogic.Business.Specs;
using DomainLogic.Business.GraphicCards;
using DomainLogic.Business.Specs;

namespace ApplicationLogic.Business.GraphicCards.Profiles
{
    public class GraphicCardDtoToGraphicCard : AutoMapper.Profile
    {
        public GraphicCardDtoToGraphicCard()
        {
            CreateMap<GraphicCardDto, GraphicCard>()
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dst => dst.Wattage, opt => opt.MapFrom(src => src.Wattage))
                .ForMember(dst => dst.InterfaceType, opt => opt.MapFrom(src => src.InterfaceType))
                .ForMember(dst => dst.ProcessorSpeed, opt => opt.MapFrom(src => src.ProcessorSpeed))
                .ForPath(dst => dst.Ram.Capacity, opt => opt.MapFrom(src => src.RamCapacity))
                .ForPath(dst => dst.Ram.TypeOfRam, opt => opt.MapFrom(src => src.RamType))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}